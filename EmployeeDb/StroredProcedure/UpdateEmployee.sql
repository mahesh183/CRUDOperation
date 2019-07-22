CREATE PROCEDURE [dbo].[UpadateEmployee]
@EmployeeId    INT,
@FirstName     NVARCHAR(50),
@LastName      NVARCHAR(50),
@Designation   NVARCHAR(50),
@Age           INT,
@Salary        INT,
@Gender        NVARCHAR(10)
AS
BEGIN
	UPDATE  Employee SET 
	EmployeeId = @EmployeeId ,
	FirstName = @FirstName,
	LastName = @LastName,
	Designation = @Designation ,
	Age = @Age,
	Salary = @Salary,
	Gender = @Gender
END
GO
