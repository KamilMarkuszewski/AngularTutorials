
CREATE TABLE Courses
(
	ID INT IDENTITY (1,1) NOT NULL,  
	Title nvarchar(250) NOT NULL,
	Credits decimal(19,2) NOT NULL,
	CONSTRAINT PK_Courses_ID PRIMARY KEY CLUSTERED (ID)  
)


Go

CREATE TABLE Students
(
	ID INT IDENTITY (1,1) NOT NULL,  
	LastName nvarchar(250) NOT NULL,
	FirstName nvarchar(250) NOT NULL,
	EnrollmentDate datetime2 NOT NULL,
	CONSTRAINT PK_Students_ID PRIMARY KEY CLUSTERED (ID)  
)

GO

CREATE TABLE Enrollments
(
	ID INT IDENTITY (1,1) NOT NULL,  
	CourseID INT NOT NULL,
	StudentsID INT NOT NULL,
	EnrollmentDate datetime2 NOT NULL,
	CONSTRAINT PK_Enrollments_ID PRIMARY KEY CLUSTERED (ID)  
)

Go


Alter table dbo.Enrollments
Add CONSTRAINT FK_Enrollments_CourseID FOREIGN KEY (CourseID)     
REFERENCES dbo.Courses (ID)     

GO    

Alter table dbo.Enrollments
Add CONSTRAINT FK_Enrollments_StudentsID FOREIGN KEY (StudentsID)     
REFERENCES dbo.Students (ID)     

GO    
