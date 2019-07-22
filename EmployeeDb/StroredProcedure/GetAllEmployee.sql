CREATE PROCEDURE [dbo].[GetAllEmployee]
@EmployeeId int,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Designation nvarchar(50),
@Age int,
@Salary int,
@Gender nvarchar(10)
as
Begin
	SELECT * FROM Employee
End
GO
