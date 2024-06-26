-- Database Section
-- ________________ 

create database space_bases;
use space_bases;


-- Tables Section
-- _____________ 

create table agencies (
     agencyName char(60) not null,
     acronym char(30) not null,
     foundationDate date not null,
     email char(30) not null,
     password char(30) not null,
     headquarterNation char(30) not null, 
     headquarterCity char(30) not null,
     spaceAgency bool not null,
     representativeID char(30) not null,
     constraint PKagencies primary key (acronym));

create table bases (
     baseName char(60) not null,
     acronym char(30) not null,
     nation char(30) not null,
     city char(30) not null,
     agencyAcronym char(30),
     constraint PKbases primary key (baseName));

create table engines (
     engineName char(30) not null,
     thrust int not null,
     chamberPressure int not null,
     throttleable bool not null,
     fuel char(30) not null,
     oxidizer char(30) not null,
     agencyAcronym char(30) not null,
     constraint PKengines primary key (engineName));

create table launches (
     rocketName char(30) not null,
     SN int not null,
     date date not null,
     altitude int not null,
     launchCost long not null,
     payloadWeight int,
     sellerAgencyAcronym char(30) not null,
     buyerAgencyAcronym char(30),
     baseName char(60) not null,
     launchpadCode int not null,
     constraint PKlaunches primary key (rocketName, SN, date));

create table launchpads (
     baseName char(60) not null,
     launchpadName char(30) not null,
     launchpadCode int not null,
     weightCapacity int not null,
     constructionDate date not null,
     launchesHosted int not null default 0,
     active bool not null,
     constraint PKlaunchpads primary key (baseName, launchpadCode));

create table powers (
     engineName char(30) not null,
     rocketName char(30) not null,
     count int not null,
     constraint PKpowers primary key (rocketName, engineName));

create table produced_rockets (
     rocketName char(30) not null,
     SN int not null,
     productionDate date not null,
     flightsExecuted int not null default 0,
     constraint PKproduced_rocketsT primary key (rocketName, SN));

create table representatives (
     name char(30) not null,
     surname char(30) not null,
     birthday date not null,
     ID char(30) not null,
     phone int not null,
     city char(30) not null,
     email char(30) not null,
     constraint PKrepresentatives primary key (ID));

create table rockets (
     rocketName char(30) not null,
     fueledWeight int not null,
     height int not null,
     width int not null,
     stages int not null,
     maxAltitude int not null,
     maxLaunches int not null,
     trajectoryType char(30) not null,
     agencyAcronym char(30) not null,
     constraint PKrockets primary key (rocketName));


-- Constraints Section
-- ___________________ 

alter table agencies add constraint FKrepresentation
     foreign key (representativeID)
     references representatives (ID);

alter table bases add constraint FKownership
     foreign key (agencyAcronym)
     references agencies (acronym);

alter table engines add constraint FKengine_development
     foreign key (agencyAcronym)
     references agencies (acronym);

alter table launches add constraint FKsale
     foreign key (sellerAgencyAcronym)
     references agencies (acronym);

alter table launches add constraint FKpurchase
     foreign key (buyerAgencyAcronym)
     references agencies (acronym);

alter table launches add constraint FKoperation
     foreign key (rocketName, SN)
     references produced_rockets (rocketName, SN);

alter table launches add constraint FKliftoff
     foreign key (baseName, launchpadCode)
     references launchpads (baseName, launchpadCode);

alter table launchpads add constraint FKcomposition
     foreign key (baseName)
     references bases (baseName);

alter table powers add constraint FKrocketName
     foreign key (rocketName)
     references rockets (rocketName);

alter table powers add constraint FKengineName
     foreign key (engineName)
     references engines (engineName);

alter table produced_rockets add constraint FKproduction
     foreign key (rocketName)
     references rockets (rocketName);

alter table rockets add constraint FKrocket_development
     foreign key (agencyAcronym)
     references agencies (acronym);

-- Initialization Section
-- _____________ 

-- Inserting more data into representatives table with real-world agency representatives
INSERT INTO representatives (name, surname, birthday, ID, phone, city, email) VALUES
('Bill', 'Nelson', '1942-09-29', 'REP001', 1234567890, 'Miami', 'bill.nelson@nasa.gov'), -- NASA
('Josef', 'Aschbacher', '1962-07-07', 'REP002', 1234567891, 'Vienna', 'josef.aschbacher@esa.int'), -- ESA
('Elon', 'Musk', '1971-06-28', 'REP003', 1234567892, 'Hawthorne', 'elon.musk@spacex.com'), -- SpaceX
('Bob', 'Smith', '1965-10-20', 'REP004', 1234567893, 'Kent', 'bob.smith@blueorigin.com'), -- Blue Origin
('Peter', 'Beck', '1976-11-05', 'REP005', 1234567894, 'Long Beach', 'peter.beck@rocketlabusa.com'), -- Rocket Lab
('Tory', 'Bruno', '1961-11-03', 'REP006', 1234567895, 'Centennial', 'tory.bruno@ulalaunch.com'), -- ULA
('Dmitry', 'Rogozin', '1963-12-21', 'REP007', 1234567896, 'Moscow', 'dmitry.rogozin@roscosmos.ru'); -- Roscosmos

-- Inserting more data into agencies table
INSERT INTO agencies (agencyName, acronym, foundationDate, email, password, headquarterNation, headquarterCity, spaceAgency, representativeID) VALUES
('National Aeronautics and Space Administration', 'NASA', '1958-07-29', 'contact@nasa.gov', 'pass1234', 'USA', 'Washington', TRUE, 'REP001'),
('European Space Agency', 'ESA', '1975-05-30', 'contact@esa.int', 'pass1234', 'France', 'Paris', TRUE, 'REP002'),
('SpaceX', 'SPX', '2002-03-14', 'info@spacex.com', 'pass1234', 'USA', 'Hawthorne', TRUE, 'REP003'),
('Blue Origin', 'BO', '2000-09-08', 'info@blueorigin.com', 'pass1234', 'USA', 'Kent', TRUE, 'REP004'),
('Rocket Lab', 'RL', '2006-06-24', 'contact@rocketlabusa.com', 'pass1234', 'USA', 'Long Beach', TRUE, 'REP005'),
('United Launch Alliance', 'ULA', '2006-12-01', 'contact@ulalaunch.com', 'pass1234', 'USA', 'Centennial', TRUE, 'REP006'),
('Roscosmos', 'ROSCOSMOS', '1992-02-25', 'info@roscosmos.ru', 'pass1234', 'Russia', 'Moscow', TRUE, 'REP007');

-- Inserting more data into bases table, ensuring all bases are located in the USA
INSERT INTO bases (baseName, acronym, nation, city, agencyAcronym) VALUES
('Kennedy Space Center', 'KSC', 'USA', 'Cape Canaveral', 'NASA'),
('Cape Canaveral Space Force Station', 'CCSFS', 'USA', 'Cape Canaveral', 'ULA'),
('Vandenberg Space Force Base', 'VSFB', 'USA', 'Lompoc', 'SPX'),
('SpaceX South Texas Launch Site', 'STLS', 'USA', 'Boca Chica', 'SPX'),
('Rocket Lab Launch Complex 2', 'LC-2', 'USA', 'Wallops Island', 'RL');

-- Inserting more data into engines table
INSERT INTO engines (engineName, thrust, chamberPressure, throttleable, fuel, oxidizer, agencyAcronym) VALUES
('Merlin', 845000, 100, TRUE, 'RP-1', 'LOX', 'SPX'),
('Raptor', 2000000, 300, TRUE, 'Methane', 'LOX', 'SPX'),
('RS-25', 1860000, 200, TRUE, 'LH2', 'LOX', 'NASA'),
('BE-3', 490000, 120, TRUE, 'LH2', 'LOX', 'BO'),
('Rutherford', 24000, 50, TRUE, 'RP-1', 'LOX', 'RL'),
('RD-180', 933000, 261, FALSE, 'RP-1', 'LOX', 'ULA'),
('RD-191', 425000, 250, TRUE, 'RP-1', 'LOX', 'ROSCOSMOS'),
('SRB', 1600000, 100, FALSE, 'Solid', 'Solid', 'NASA');

-- Inserting more data into rockets table
INSERT INTO rockets (rocketName, fueledWeight, height, width, stages, maxAltitude, maxLaunches, trajectoryType, agencyAcronym) VALUES
('Falcon 9', 549054, 70, 3.7, 2, 120000, 10, 'orbital', 'SPX'),
('Starship', 1335000, 120, 9, 2, 100000, 100, 'orbital', 'SPX'),
('SLS', 2600000, 98, 8.4, 2, 130000, 5, 'orbital', 'NASA'),
('New Shepard', 75000, 18, 3.7, 1, 100, 50, 'suborbital', 'BO'),
('Electron', 12500, 18, 1.2, 2, 500, 5, 'orbital', 'RL'),
('Vega', 137000, 30, 3, 4, 700, 10, 'orbital', 'ESA'),
('Pegasus', 23100, 17.6, 1.27, 3, 1000, 10, 'orbital', 'NASA'),
('Atlas V', 334500, 58.3, 3.81, 2, 185000, 20, 'orbital', 'ULA'),
('Soyuz', 312000, 46.1, 2.95, 3, 120000, 10, 'orbital', 'ROSCOSMOS');

-- Inserting more data into produced_rockets table
INSERT INTO produced_rockets (rocketName, SN, productionDate) VALUES
('Falcon 9', 1, '2015-12-21'),
('Falcon 9', 2, '2016-03-14'),
('Falcon 9', 3, '2017-01-08'),
('Falcon 9', 4, '2018-06-29'),
('Falcon 9', 5, '2019-11-11'),
('Starship', 1, '2021-05-05'),
('Starship', 2, '2022-09-01'),
('Starship', 3, '2023-03-20'),
('SLS', 1, '2020-11-16'),
('New Shepard', 1, '2018-04-29'),
('New Shepard', 2, '2019-12-15'),
('New Shepard', 3, '2020-11-20'),
('Electron', 1, '2018-01-21'),
('Electron', 2, '2019-06-29'),
('Vega', 1, '2012-02-13'),
('Vega', 2, '2014-04-29'),
('Pegasus', 1, '1990-04-05'),
('Pegasus', 2, '1994-05-19'),
('Atlas V', 1, '2002-08-21'),
('Atlas V', 2, '2004-12-18'),
('Soyuz', 1, '2001-11-07'),
('Soyuz', 2, '2004-04-19');

-- Inserting more data into launchpads table
INSERT INTO launchpads (baseName, launchpadName, launchpadCode, weightCapacity, constructionDate, active) VALUES
('Kennedy Space Center', 'LC-39A', 1, 2500000, '1967-11-09', TRUE),
('Cape Canaveral Space Force Station', 'SLC-41', 2, 3400000, '1965-12-21', TRUE),
('Vandenberg Space Force Base', 'SLC-4E', 3, 2000000, '2013-07-11', TRUE),
('SpaceX South Texas Launch Site', 'Boca Chica Pad', 4, 5000000, '2019-09-28', TRUE),
('Rocket Lab Launch Complex 2', 'LC-2', 5, 225000, '2019-12-12', TRUE);

-- Inserting more data into launches table
INSERT INTO launches (rocketName, SN, date, altitude, launchCost, payloadWeight, sellerAgencyAcronym, buyerAgencyAcronym, baseName, launchpadCode) VALUES
('Falcon 9', 1, '2024-07-15', 55000, 62000000, 8300, 'SPX', 'NASA', 'Kennedy Space Center', 1),
('Falcon 9', 2, '2023-05-11', 55000, 62000000, 8300, 'SPX', 'ESA', 'Cape Canaveral Space Force Station', 2),
('Falcon 9', 3, '2024-10-10', 55000, 62000000, NULL, 'SPX', NULL, 'Kennedy Space Center', 1), -- Not bought yet, future date
('Falcon 9', 4, '2023-08-06', 55000, 62000000, 8300, 'SPX', 'ROSCOSMOS', 'Vandenberg Space Force Base', 3),
('Falcon 9', 5, '2024-09-12', 55000, 62000000, NULL, 'SPX', NULL, 'Kennedy Space Center', 1), -- Not bought yet, future date
('Starship', 1, '2024-11-20', 350000, 200000000, NULL, 'SPX', NULL, 'SpaceX South Texas Launch Site', 4), -- Not bought yet, future date
('Starship', 2, '2024-03-14', 350000, 200000000, 50000, 'SPX', 'NASA', 'SpaceX South Texas Launch Site', 4),
('Starship', 3, '2024-08-20', 350000, 200000000, NULL, 'SPX', NULL, 'SpaceX South Texas Launch Site', 4), -- Not bought yet, future date
('SLS', 1, '2024-12-18', 1000, 5000000, 400, 'NASA', 'NASA', 'Kennedy Space Center', 1),
('New Shepard', 1, '2024-07-15', 100, 500000, 100, 'BO', 'NASA', 'Rocket Lab Launch Complex 2', 5),
('Electron', 1, '2023-01-10', 500, 6000000, 200, 'RL', 'ESA', 'Rocket Lab Launch Complex 2', 5),
('Vega', 1, '2023-04-13', 700, 37000000, 1200, 'ESA', 'NASA', 'Cape Canaveral Space Force Station', 2),
('Pegasus', 1, '2023-06-10', 1000, 18000000, 400, 'NASA', 'ESA', 'Kennedy Space Center', 1),
('Atlas V', 1, '2023-11-20', 185000, 150000000, 4000, 'ULA', 'NASA', 'Cape Canaveral Space Force Station', 2),
('Soyuz', 1, '2023-09-12', 120000, 70000000, 3000, 'ROSCOSMOS', 'ESA', 'Vandenberg Space Force Base', 3);

-- Inserting more data into powers table
INSERT INTO powers (engineName, rocketName, count) VALUES
('Merlin', 'Falcon 9', 9),
('Raptor', 'Starship', 6),
('RS-25', 'SLS', 4),
('SRB', 'SLS', 2),
('BE-3', 'New Shepard', 1),
('Rutherford', 'Electron', 9),
('RS-25', 'Pegasus', 3),
('RD-180', 'Atlas V', 2),
('RD-191', 'Soyuz', 4);

SET SQL_SAFE_UPDATES = 0;

-- Update launchpads.launchesHosted to reflect the number of flights from each launchpad (excluding NULL buyerAgencyAcronym and payloadWeight)
UPDATE launchpads SET launchesHosted = (
    SELECT COUNT(*)
    FROM launches
    WHERE launches.baseName = launchpads.baseName
    AND launches.launchpadCode = launchpads.launchpadCode
    AND launches.buyerAgencyAcronym IS NOT NULL
    AND launches.payloadWeight IS NOT NULL
);

-- Update produced_rockets.flightsExecuted to reflect the number of flights of each produced rocket in table launches
UPDATE produced_rockets SET flightsExecuted = (
    SELECT COUNT(*)
    FROM launches
    WHERE launches.rocketName = produced_rockets.rocketName
    AND launches.SN = produced_rockets.SN
);

SET SQL_SAFE_UPDATES = 1;
