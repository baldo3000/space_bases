using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace space_bases.SpaceBases;

public partial class SpaceBasesContext : DbContext
{
    public SpaceBasesContext()
    {
    }

    public SpaceBasesContext(DbContextOptions<SpaceBasesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agency> Agencies { get; set; }

    public virtual DbSet<Base> Bases { get; set; }

    public virtual DbSet<Engine> Engines { get; set; }

    public virtual DbSet<Launch> Launches { get; set; }

    public virtual DbSet<Launchpad> Launchpads { get; set; }

    public virtual DbSet<Power> Powers { get; set; }

    public virtual DbSet<ProducedRocket> ProducedRockets { get; set; }

    public virtual DbSet<Representative> Representatives { get; set; }

    public virtual DbSet<Rocket> Rockets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;uid=root;pwd=;database=space_bases");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agency>(entity =>
        {
            entity.HasKey(e => e.Acronym).HasName("PRIMARY");

            entity.ToTable("agencies");

            entity.HasIndex(e => e.RepresentativeId, "FKrepresentation");

            entity.Property(e => e.Acronym)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("acronym");
            entity.Property(e => e.AgencyName)
                .HasMaxLength(60)
                .IsFixedLength()
                .HasColumnName("agencyName");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.FoundationDate)
                .HasColumnType("date")
                .HasColumnName("foundationDate");
            entity.Property(e => e.HeadquarterCity)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("headquarterCity");
            entity.Property(e => e.HeadquarterNation)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("headquarterNation");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.RepresentativeId)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("representativeID");
            entity.Property(e => e.SpaceAgency).HasColumnName("spaceAgency");

            entity.HasOne(d => d.Representative).WithMany(p => p.Agencies)
                .HasForeignKey(d => d.RepresentativeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKrepresentation");
        });

        modelBuilder.Entity<Base>(entity =>
        {
            entity.HasKey(e => e.BaseName).HasName("PRIMARY");

            entity.ToTable("bases");

            entity.HasIndex(e => e.AgencyAcronym, "FKownership");

            entity.Property(e => e.BaseName)
                .HasMaxLength(60)
                .IsFixedLength()
                .HasColumnName("baseName");
            entity.Property(e => e.Acronym)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("acronym");
            entity.Property(e => e.AgencyAcronym)
                .HasMaxLength(30)
                .HasDefaultValueSql("'NULL'")
                .IsFixedLength()
                .HasColumnName("agencyAcronym");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("city");
            entity.Property(e => e.Nation)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("nation");

            entity.HasOne(d => d.AgencyAcronymNavigation).WithMany(p => p.Bases)
                .HasForeignKey(d => d.AgencyAcronym)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKownership");
        });

        modelBuilder.Entity<Engine>(entity =>
        {
            entity.HasKey(e => e.EngineName).HasName("PRIMARY");

            entity.ToTable("engines");

            entity.HasIndex(e => e.AgencyAcronym, "FKengine_development");

            entity.Property(e => e.EngineName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("engineName");
            entity.Property(e => e.AgencyAcronym)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("agencyAcronym");
            entity.Property(e => e.ChamberPressure)
                .HasColumnType("int(11)")
                .HasColumnName("chamberPressure");
            entity.Property(e => e.Fuel)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("fuel");
            entity.Property(e => e.Oxidizer)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("oxidizer");
            entity.Property(e => e.Throttleable).HasColumnName("throttleable");
            entity.Property(e => e.Thrust)
                .HasColumnType("int(11)")
                .HasColumnName("thrust");

            entity.HasOne(d => d.AgencyAcronymNavigation).WithMany(p => p.Engines)
                .HasForeignKey(d => d.AgencyAcronym)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKengine_development");
        });

        modelBuilder.Entity<Launch>(entity =>
        {
            entity.HasKey(e => new { e.RocketName, e.Sn, e.Date }).HasName("PRIMARY");

            entity.ToTable("launches");

            entity.HasIndex(e => new { e.BaseName, e.LaunchpadCode }, "FKliftoff");

            entity.HasIndex(e => e.BuyerAgencyAcronym, "FKpurchase");

            entity.HasIndex(e => e.SellerAgencyAcronym, "FKsale");

            entity.Property(e => e.RocketName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("rocketName");
            entity.Property(e => e.Sn)
                .HasColumnType("int(11)")
                .HasColumnName("SN");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Altitude)
                .HasColumnType("int(11)")
                .HasColumnName("altitude");
            entity.Property(e => e.BaseName)
                .HasMaxLength(60)
                .IsFixedLength()
                .HasColumnName("baseName");
            entity.Property(e => e.BuyerAgencyAcronym)
                .HasMaxLength(30)
                .HasDefaultValueSql("'NULL'")
                .IsFixedLength()
                .HasColumnName("buyerAgencyAcronym");
            entity.Property(e => e.LaunchCost)
                .HasColumnType("mediumtext")
                .HasColumnName("launchCost");
            entity.Property(e => e.LaunchpadCode)
                .HasColumnType("int(11)")
                .HasColumnName("launchpadCode");
            entity.Property(e => e.PayloadWeight)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payloadWeight");
            entity.Property(e => e.SellerAgencyAcronym)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("sellerAgencyAcronym");

            entity.HasOne(d => d.BuyerAgencyAcronymNavigation).WithMany(p => p.LaunchBuyerAgencyAcronymNavigations)
                .HasForeignKey(d => d.BuyerAgencyAcronym)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKpurchase");

            entity.HasOne(d => d.SellerAgencyAcronymNavigation).WithMany(p => p.LaunchSellerAgencyAcronymNavigations)
                .HasForeignKey(d => d.SellerAgencyAcronym)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKsale");

            entity.HasOne(d => d.Launchpad).WithMany(p => p.Launches)
                .HasForeignKey(d => new { d.BaseName, d.LaunchpadCode })
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKliftoff");

            entity.HasOne(d => d.ProducedRocket).WithMany(p => p.Launches)
                .HasForeignKey(d => new { d.RocketName, d.Sn })
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKoperation");
        });

        modelBuilder.Entity<Launchpad>(entity =>
        {
            entity.HasKey(e => new { e.BaseName, e.LaunchpadCode }).HasName("PRIMARY");

            entity.ToTable("launchpads");

            entity.Property(e => e.BaseName)
                .HasMaxLength(60)
                .IsFixedLength()
                .HasColumnName("baseName");
            entity.Property(e => e.LaunchpadCode)
                .HasColumnType("int(11)")
                .HasColumnName("launchpadCode");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ConstructionDate)
                .HasColumnType("date")
                .HasColumnName("constructionDate");
            entity.Property(e => e.LaunchesHosted)
                .HasColumnType("int(11)")
                .HasColumnName("launchesHosted");
            entity.Property(e => e.LaunchpadName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("launchpadName");
            entity.Property(e => e.WeightCapacity)
                .HasColumnType("int(11)")
                .HasColumnName("weightCapacity");

            entity.HasOne(d => d.BaseNameNavigation).WithMany(p => p.Launchpads)
                .HasForeignKey(d => d.BaseName)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKcomposition");
        });

        modelBuilder.Entity<Power>(entity =>
        {
            entity.HasKey(e => new { e.RocketName, e.EngineName }).HasName("PRIMARY");

            entity.ToTable("powers");

            entity.HasIndex(e => e.EngineName, "FKengineName");

            entity.Property(e => e.RocketName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("rocketName");
            entity.Property(e => e.EngineName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("engineName");
            entity.Property(e => e.Count)
                .HasColumnType("int(11)")
                .HasColumnName("count");

            entity.HasOne(d => d.EngineNameNavigation).WithMany(p => p.Powers)
                .HasForeignKey(d => d.EngineName)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKengineName");

            entity.HasOne(d => d.RocketNameNavigation).WithMany(p => p.Powers)
                .HasForeignKey(d => d.RocketName)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKrocketName");
        });

        modelBuilder.Entity<ProducedRocket>(entity =>
        {
            entity.HasKey(e => new { e.RocketName, e.Sn }).HasName("PRIMARY");

            entity.ToTable("produced_rockets");

            entity.Property(e => e.RocketName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("rocketName");
            entity.Property(e => e.Sn)
                .HasColumnType("int(11)")
                .HasColumnName("SN");
            entity.Property(e => e.FlightsExecuted)
                .HasColumnType("int(11)")
                .HasColumnName("flightsExecuted");
            entity.Property(e => e.ProductionDate)
                .HasColumnType("date")
                .HasColumnName("productionDate");

            entity.HasOne(d => d.RocketNameNavigation).WithMany(p => p.ProducedRockets)
                .HasForeignKey(d => d.RocketName)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKproduction");
        });

        modelBuilder.Entity<Representative>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("representatives");

            entity.Property(e => e.Id)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("ID");
            entity.Property(e => e.Birthday)
                .HasColumnType("date")
                .HasColumnName("birthday");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("city");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasColumnType("int(11)")
                .HasColumnName("phone");
            entity.Property(e => e.Surname)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("surname");
        });

        modelBuilder.Entity<Rocket>(entity =>
        {
            entity.HasKey(e => e.RocketName).HasName("PRIMARY");

            entity.ToTable("rockets");

            entity.HasIndex(e => e.AgencyAcronym, "FKrocket_development");

            entity.Property(e => e.RocketName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("rocketName");
            entity.Property(e => e.AgencyAcronym)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("agencyAcronym");
            entity.Property(e => e.FueledWeight)
                .HasColumnType("int(11)")
                .HasColumnName("fueledWeight");
            entity.Property(e => e.Height)
                .HasColumnType("int(11)")
                .HasColumnName("height");
            entity.Property(e => e.MaxAltitude)
                .HasColumnType("int(11)")
                .HasColumnName("maxAltitude");
            entity.Property(e => e.MaxLaunches)
                .HasColumnType("int(11)")
                .HasColumnName("maxLaunches");
            entity.Property(e => e.Stages)
                .HasColumnType("int(11)")
                .HasColumnName("stages");
            entity.Property(e => e.TrajectoryType)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("trajectoryType");
            entity.Property(e => e.Width)
                .HasColumnType("int(11)")
                .HasColumnName("width");

            entity.HasOne(d => d.AgencyAcronymNavigation).WithMany(p => p.Rockets)
                .HasForeignKey(d => d.AgencyAcronym)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FKrocket_development");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
