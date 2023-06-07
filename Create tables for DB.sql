USE practice_Trek;

CREATE TABLE dbo.Tires(
	tireId			INT IDENTITY (1, 1) PRIMARY KEY, 
	tireName		NVARCHAR (MAX) NOT NULL, 
	tireDescription	NVARCHAR (MAX) NOT NULL, 
	tireQuantity	INT NOT NULL);

CREATE TABLE dbo.Hubs(
	hubId			INT IDENTITY (1, 1) PRIMARY KEY, 
	hubName			NVARCHAR (MAX) NOT NULL, 
	hubDescription	NVARCHAR (MAX) NOT NULL, 
	hubQuantity		INT NOT NULL);

CREATE TABLE dbo.Rims(
	rimId			INT IDENTITY (1, 1) PRIMARY KEY, 
	rimName			NVARCHAR (MAX) NOT NULL, 
	rimDescription	NVARCHAR (MAX) NOT NULL, 
	rimQuantity		INT NOT NULL);

CREATE TABLE dbo.Wheelsets(
	wheelsetId	INT IDENTITY (1, 1) PRIMARY KEY,
	hubId INT,
	rimId INT,
	tireId INT,
	FOREIGN KEY (hubId) REFERENCES dbo.Hubs (hubId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (rimId) REFERENCES dbo.Rims (rimId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (tireId) REFERENCES dbo.Tires (tireId) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE dbo.Shifters(
	shifterId	INT IDENTITY (1, 1) PRIMARY KEY,
	shifterName NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Cassettes(
	cassetteId	INT IDENTITY (1, 1) PRIMARY KEY,
	cassetteName NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Switches(
	switchId	INT IDENTITY (1, 1) PRIMARY KEY,
	switchName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Transmitions(
	transmitionId INT IDENTITY (1, 1) PRIMARY KEY, 
	cassetteId INT, 
	switchId INT, 
	shifterId INT,
	FOREIGN KEY (cassetteId) REFERENCES dbo.Cassettes (cassetteId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (switchId) REFERENCES dbo.Switches (switchId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (shifterId) REFERENCES dbo.Shifters (shifterId) ON DELETE CASCADE ON UPDATE CASCADE,
	transmitionQuantity INT NOT NULL);

CREATE TABLE dbo.Pedalses(
	pedalsId	INT IDENTITY (1, 1) PRIMARY KEY, 
	pedalsName	NVARCHAR (MAX) NOT NULL, 
	pedalsQuantity INT NOT NULL);

CREATE TABLE dbo.Carriages(
	carriageId	INT IDENTITY (1, 1) PRIMARY KEY,
	carriageName NVARCHAR (MAX) NOT NULL, 
	carriageQuantity INT NOT NULL);

CREATE TABLE dbo.Groopsets(
	groopsetId	INT IDENTITY (1, 1) PRIMARY KEY,
	transmitionId INT,
	carriageId INT,
	pedalsId INT,
	FOREIGN KEY (transmitionId) REFERENCES dbo.Transmitions (transmitionId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (carriageId) REFERENCES dbo.Carriages (carriageId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (pedalsId) REFERENCES dbo.Pedalses (pedalsId) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE dbo.Frames(
	frameId	INT IDENTITY (1, 1) PRIMARY KEY, 
	frameName	NVARCHAR (MAX) NOT NULL, 
	frameDescription	NVARCHAR (MAX) NOT NULL, 
	frameQuantity INT NOT NULL);

CREATE TABLE dbo.Forks(
	forkId	INT IDENTITY (1, 1) PRIMARY KEY, 
	forkName	NVARCHAR (MAX) NOT NULL, 
	forkDescription	NVARCHAR (MAX) NOT NULL, 
	forkQuantity INT NOT NULL);

CREATE TABLE dbo.Framesets(
	framesetId	INT IDENTITY (1, 1) PRIMARY KEY, 
	frameId INT, 
	forkId INT,
	FOREIGN KEY (frameId) REFERENCES dbo.Frames (frameId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (forkId) REFERENCES dbo.Forks (forkId) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE dbo.Stems(
	stemId	INT IDENTITY (1, 1) PRIMARY KEY, 
	stemName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Steerings(
	steeringId	INT IDENTITY (1, 1) PRIMARY KEY, 
	steeringName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.SeatPosts(
	seatPostId	INT IDENTITY (1, 1) PRIMARY KEY, 
	seatPostName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Saddles(
	saddleId	INT IDENTITY (1, 1) PRIMARY KEY, 
	saddleName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Handlebars(
	handlbarId	INT IDENTITY (1, 1) PRIMARY KEY, 
	handlbarName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Gripses(
	gripsId	INT IDENTITY (1, 1) PRIMARY KEY, 
	gripsName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Brakes(
	brakeId	INT IDENTITY (1, 1) PRIMARY KEY, 
	brakeName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Equipments(
	equipmentId	INT IDENTITY (1, 1) PRIMARY KEY, 
	brakeId INT,
	saddleId INT, 
	seatPostId INT, 
	stemId INT, 
	handlebarId INT, 
	gripsId INT, 
	steeringId INT,
	FOREIGN KEY (brakeId) REFERENCES dbo.Brakes (brakeId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (saddleId) REFERENCES dbo.Saddles (saddleId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (seatPostId) REFERENCES dbo.SeatPosts (seatPostId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (stemId) REFERENCES dbo.Stems (stemId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (handlebarId) REFERENCES dbo.Handlebars (handlbarId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (gripsId) REFERENCES dbo.Gripses (gripsId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (steeringId) REFERENCES dbo.Steerings (steeringId) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE dbo.TypeOfBikes(
	typeOfBikeId	INT IDENTITY (1, 1) PRIMARY KEY, 
	typeName	NVARCHAR (MAX) NOT NULL);

CREATE TABLE dbo.Bikes(
	bikeId	INT IDENTITY (1, 1) PRIMARY KEY, 
	bikeName	NVARCHAR (MAX) NOT NULL, 
	bikeImage	NVARCHAR (MAX) NOT NULL, 
	bikeDescription	NVARCHAR (MAX) NOT NULL, 
	bikePrice INT NOT NULL, 
	bikeWeight FLOAT(2) NOT NULL,
	framesetId INT, 
	wheelsetId INT, 
	groopsetId INT, 
	equipmentId INT, 
	typeOfBikeId INT,
	FOREIGN KEY (framesetId) REFERENCES dbo.Framesets (framesetId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (wheelsetId) REFERENCES dbo.Wheelsets (wheelsetId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (groopsetId) REFERENCES dbo.Groopsets (groopsetId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (equipmentId) REFERENCES dbo.Equipments (equipmentId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (typeOfBikeId) REFERENCES dbo.TypeOfBikes (typeOfBikeId) ON DELETE CASCADE ON UPDATE CASCADE);


CREATE TABLE dbo.Factories(
	factoryId INT IDENTITY (1, 1) PRIMARY KEY,
	city NVARCHAR(MAX),
	street NVARCHAR(MAX),
	zipCode INT
	);

CREATE TABLE dbo.JobTitles(
	jobTitleId INT IDENTITY (1, 1) PRIMARY KEY,
	jobTitle NVARCHAR(MAX)
	);

CREATE TABLE dbo.Staffs(
	staffId INT IDENTITY (1, 1) PRIMARY KEY,
	firstName NVARCHAR(MAX),
	secondName NVARCHAR(MAX),
	factoryId INT,
	jobTitleId INT,
	FOREIGN KEY (factoryId) REFERENCES dbo.Factories (factoryId) ON DELETE CASCADE ON UPDATE CASCADE, 
	FOREIGN KEY (jobTitleId) REFERENCES dbo.JobTitles (jobTitleId) ON DELETE CASCADE ON UPDATE CASCADE);