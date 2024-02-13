USE db_aa5307_artursobol666

CREATE TABLE Contact(
	Id int IDENTITY(1,1) NOT NULL,
	FullName varchar(50) NULL,
	Number varchar(50) NULL,
	DateOfBirth date NULL
) ON [PRIMARY]



CREATE PROCEDURE AddContact
    @FullName NVARCHAR(100),
    @Number NVARCHAR(50),
    @DateOfBirth DATETIME
AS
BEGIN
    INSERT INTO Contact(FullName, Number, DateOfBirth)
    VALUES(@FullName, @Number, @DateOfBirth)
END


CREATE PROCEDURE DeleteContact
    @Id INT
AS
BEGIN
    DELETE FROM Contact WHERE Id = @Id
END


CREATE PROCEDURE  SelectAllContacts
AS
BEGIN
	SELECT * FROM Contact
END


CREATE PROCEDURE  UpdateContact
    @Id INT,
    @FullName NVARCHAR(100),
    @Number NVARCHAR(50),
    @DateOfBirth DATETIME
AS
BEGIN
    UPDATE Contact
    SET FullName = @FullName, Number = @Number, DateOfBirth = @DateOfBirth
    WHERE Id = @Id
END


