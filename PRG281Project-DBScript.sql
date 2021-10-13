CREATE DATABASE BelgiumStudents
GO
USE BelgiumStudents
GO
CREATE TABLE Student
(
	StudentNumber int,
	StudentName VARCHAR(50),
	StudentSurname VARCHAR(50),
	DateofBirth VARCHAR(50),
	Gender VARCHAR(50),
	StudentPhoneNumber VARCHAR(50),
	StudentAddress VARCHAR(50),
	StudentPhoto varbinary(max),

);
GO
USE BelgiumStudents
GO
CREATE TABLE Module
(
	ModuleCode VARCHAR(10),
	StudentNumber int,
	ModuleName VARCHAR(50),
	ModuleDesc VARCHAR(50),
	ModuleLink VARCHAR(100),
);
GO
INSERT INTO Module VALUES ('PRG281', 1, 'Programming 281','Indepth module on C#','https://www.youtube.com/watch?v=GhQdlIFylQ8&t=35s');
INSERT INTO Module VALUES ('PRG282', 2, 'Programming with Database','C# and SQL sever manager combined','https://www.youtube.com/watch?v=GVV-LUcmCOE');
INSERT INTO Module VALUES ('MAT281', 3, 'Math','The unsolvable math problem','https://www.youtube.com/watch?v=094y1Z2wpJg&t=480s');
INSERT INTO Module VALUES ('DBD281', 4, 'Database','SQL Sever','https://www.youtube.com/watch?v=WttoAlS__8k');
INSERT INTO Module VALUES ('STA281', 5,'Statistics','Intro to stats','https://www.youtube.com/watch?v=GUQJ7zMoSCM&t=3s');
GO
INSERT INTO Student VALUES (1, 'Ryan', 'Mc Callum', '18-01-2001','Male','084 487 0795', '214 North Street', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (2, 'Roche', 'Stapelberg', '07-07-1999','Male','083 140 7817', '546 Tait St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (3, 'Herman', 'Potgieter', '08-02-2001','Male','084 621 0817', '2086 Broad Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (4, 'Liam', 'Smith', '20-02-2001','Male','082 883 9562', '2416 Wattle St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (5, 'Emma', 'Johnson', '10-07-2002','Female','085 458 6960', '798 Main Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (6, 'Noah', 'Brown', '14-08-1998','Male','084 207 6462', '1557 Gemsbok St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (7, 'Ava', 'Jones', '16-01-1996','Female','083 914 5918', '1741 Gleemoor Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (8, 'Oliver', 'Garcia', '22-04-2001','Male','083 629 2913', '930 Fox St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (9, 'Sophia', 'Miller', '08-05-2001','Female','083 469 3418', '1324 Mosman Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (10, 'Amelia', 'Davis', '11-11-1998','Female','085 951 3990', '327 Roger St', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (11, 'Isabella', 'Rodriguez', '05-01-2000','Female','085 643 8620', '895 Hoog St', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (12, 'Mia', 'Thomas', '26-08-2001','Female','085 355 7216', '900 Kort St', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (13, 'James', 'Jackson', '27-04-2001','Male','084 180 5595', '849 Fox St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (14, 'William', 'Taylor', '28-04-1998','Male','083 913 4967', '463 Bath Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (15, 'Simba', 'Zengeni', '06-06-1989','Male','085 431 0333', '538 Uitsig St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (16, 'Tendi', 'Mkwaira', '17-04-1988','Male','083 674 1739', '1568 Thomas St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (17, 'Valdez', 'Pretourius', '29-09-1992','Male','082 754 2679', '2209 Bath Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (18, 'Lucas', 'Thompson', '26-12-2001','Male','083 522 4432', '2049 Mosman Rd', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (19, 'Deborah', 'Oluwadele', '24-07-1991','Female','082 476 6993', '1881 St. John Street', (SELECT * FROM OPENROWSET(BULK N'C:\img\female.png', SINGLE_BLOB) as T1));
INSERT INTO Student VALUES (20, 'Alex', 'Harris', '02-02-2001','Male','082 506 6176', '1545 Doreen St', (SELECT * FROM OPENROWSET(BULK N'C:\img\male.png', SINGLE_BLOB) as T1));
GO
CREATE PROCEDURE spGetStudents
AS
BEGIN
	SELECT * FROM Student
END
GO
CREATE PROCEDURE spAddStudent
(
	@StudentNumber int,
	@StudentName VARCHAR(50),
	@StudentSurname VARCHAR(50),
	@DateofBirth VARCHAR(50),
	@Gender VARCHAR(50),
	@StudentPhoneNumber VARCHAR(50),
	@StudentAddress VARCHAR(50)
)
AS
BEGIN
	INSERT INTO Student
	VALUES (@StudentNumber, @StudentName, @StudentSurname, @DateofBirth, @Gender, @StudentPhoneNumber, @StudentAddress, NULL)
END
GO
CREATE PROCEDURE spUpdateStudent
(
	@StudentNumber int,
	@StudentName VARCHAR(50),
	@StudentSurname VARCHAR(50),
	@DateofBirth VARCHAR(50),
	@Gender VARCHAR(50),
	@StudentPhoneNumber VARCHAR(50),
	@StudentAddress VARCHAR(50)
)
AS
BEGIN
	UPDATE Student
	SET StudentNumber = @StudentNumber,
		StudentName = @StudentName, 
		StudentSurname = @StudentSurname, 
		DateOfBirth = @DateofBirth, 
		Gender = @Gender, 
		StudentPhoneNumber = @StudentPhoneNumber, 
		StudentAddress = @StudentAddress,
		StudentPhoto = NULL
		WHERE StudentNumber = @StudentNumber
END
GO
CREATE PROCEDURE spDeleteStudent
(
	@StudentNumber int
)
AS
BEGIN 
	DELETE FROM Student
	WHERE StudentNumber = @StudentNumber
END
GO
CREATE PROCEDURE spSearchStudent
(
	@StudentNumber int
)
AS
BEGIN 
	SELECT * FROM Student
	WHERE StudentNumber = @StudentNumber
END
GO
CREATE PROCEDURE spViewModule
AS
BEGIN
	SELECT * FROM Module
END
