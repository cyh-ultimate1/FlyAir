USE FlyAir2

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Countries](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SELECT * FROM Countries WHERE CountryName LIKE '%fr%'

SELECT loc.ID, loc.City, c.CountryName FROM
(SELECT * FROM Location WHERE City LIKE '%b%') AS loc 
INNER JOIN Countries AS c ON loc.CountryID = c.ID


SELECT * FROM Flights WHERE OriginLocID = 1 AND DestLocID = 8
AND CAST(DepartDateTime AS DATE) >= '2018-12-22';

INSERT INTO Bookings (DateTimeCreated, GoFlightId, ReturnFlightId) VALUES (GETDATE(), 1, 1)

SELECT * FROM Flights AS f INNER JOIN FlightSeatTypes AS fs ON f.FlightSeatTypeID = fs.ID AND f.OriginLocID = '1' AND f.DestLocID = '8' AND CAST(f.DepartDateTime AS DATE) >= '2018-12-20'

WITH rs AS (SELECT * FROM Bookings AS b WHERE b.ID = 4) 
SELECT *  FROM Flights AS f WHERE f.ID = (SELECT rs.GoFlightId FROM rs) OR f.ID = (SELECT rs.ReturnFlightId FROM rs)

SELECT loc.ID, loc.City, loc.CountryID, c.CountryName FROM Location AS loc INNER JOIN Countries AS c ON  c.ID = loc.CountryID

SELECT LTRIM(STR(SeatNumDigit))+SeatNumLetter FROM BookingNonMember WHERE BookingID IN (SELECT ID FROM Bookings WHERE GoFlightId = 4)
AND (SeatNumDigit IS NOT NULL OR SeatNumLetter IS NOT NULL)
ORDER BY SeatNumDigit ASC, SeatNumLetter ASC;

ALTER TABLE HomeSlidesOrder
ALTER COLUMN HomeSlideID tinyint

UPDATE BookingNonMember SET SeatNumDigitGoFlight = 3, SeatNumLetterGoFlight = 'A', SeatNumDigitReturnFlight = 5, SeatNumLetterReturnFlight = 'D'
WHERE BookingID = 4 AND ID = 7;

UPDATE Bookings SET HasCheckedIn = 'false'
WHERE ID = 4;

SELECT * FROM Staffs AS s INNER JOIN StaffTypes AS st ON s.StaffTypeID = st.ID;

SELECT * FROM Flights WHERE CONVERT(date, DepartDateTime) >= '2018-12-21' AND CONVERT(date, ArrDateTime) <= '2018-12-23'

WITH f1 AS (SELECT DepartDateTime, ArrDateTime FROM Flights WHERE ID = 3),
f2 AS (
SELECT ID FROM Flights WHERE 
(DepartDateTime BETWEEN (SELECT f1.DepartDateTime FROM f1) AND (SELECT f1.ArrDateTime FROM f1))
OR (ArrDateTime BETWEEN (SELECT f1.DepartDateTime FROM f1) AND (SELECT f1.ArrDateTime FROM f1))
OR (DepartDateTime <= (SELECT f1.DepartDateTime FROM f1) AND ArrDateTime >= (SELECT f1.ArrDateTime FROM f1)))
SELECT * FROM f1;
SELECT * FROM Staffs WHERE StaffTypeID=2 AND ID NOT IN (SELECT DISTINCT StaffID FROM FlightsStaffs WHERE StaffID IS NOT NULL AND  FlightID IN (SELECT f2.ID FROM f2))


WITH f1 AS (SELECT DepartDateTime, ArrDateTime FROM Flights WHERE ID = 2)
SELECT * FROM Planes WHERE FlightSeatTypeID=2 AND ID NOT IN (SELECT DISTINCT PlaneID FROM Flights WHERE PlaneID IS NOT NULL AND
((DepartDateTime BETWEEN (SELECT f1.DepartDateTime FROM f1) AND (SELECT f1.ArrDateTime FROM f1))
OR (ArrDateTime BETWEEN (SELECT f1.DepartDateTime FROM f1) AND (SELECT f1.ArrDateTime FROM f1))
OR (DepartDateTime <= (SELECT f1.DepartDateTime FROM f1) AND ArrDateTime >= (SELECT f1.ArrDateTime FROM f1))))


UPDATE HomeSlides SET Filename = '5_' WHERE ID = 5;

SELECT * FROM Staffs WHERE StaffTypeID=1 AND ID IN (SELECT StaffID FROM FlightsStaffs WHERE FlightID = 9);

INSERT INTO FlightsStaffs (FlightID, StaffID) 
VALUES (11, 2),
(13, 1);

SELECT hs.ID, hs.Filename, hso.ID AS DisplayOrder FROM HomeSlides AS hs LEFT JOIN HomeSlidesOrder AS hso ON hs.ID = hso.HomeSlideID ORDER BY CASE WHEN hso.ID IS NULL THEN 99999999 END, DisplayOrder;

USE MOR1
INSERT INTO HomeSlides (FileName) VALUES ('newone');
WITH lastId AS (SELECT CAST(SCOPE_IDENTITY() as int) AS lastAdded)
UPDATE HomeSlides SET FileName = (CONVERT(varchar, (SELECT lastAdded FROM lastId)) + '_') WHERE ID = (SELECT lastAdded FROM lastId);
SELECT CAST(SCOPE_IDENTITY() as int);

INSERT INTO HomeSlides (FileName) VALUES ('newone');
SELECT CAST(SCOPE_IDENTITY() as int) AS lastAdded;

WITH temp AS (SELECT ID FROM HomeSlides)
SELECT ID from temp

SELECT * FROM Planes WHERE ID = (SELECT PlaneID FROM Flights WHERE ID = 2);


ALTER DATABASE FlyAir2 SET ENABLE_BROKER;

SELECT name, is_broker_enabled FROM sys.databases

SELECT s.ID, s.Name, s.DateOfBirth, s.StaffTypeID, st.Type FROM  Staffs  AS s INNER JOIN StaffTypes AS st ON s.StaffTypeID = st.ID

DELETE FROM FlightsStaffs WHERE ID = 3;

USE FlyAir2
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF;
GO

UPDATE Flights SET SeatsRemain = ((SELECT SeatsRemain WHERE ID = 2045 )+2) WHERE ID = 2045;