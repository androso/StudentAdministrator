USE StudentAdministratorDB;
GO

CREATE TABLE student (
	idStudent INT PRIMARY KEY IDENTITY(1,1),
	nameStudent NVARCHAR(50) NOT NULL,
	lastnameStudent NVARCHAR(50) NOT NULL,
	idCareerStudent INT FOREIGN KEY REFERENCES career(idCareer)
)

INSERT INTO student VALUES ('anibal', 'andrade', 1)
GO