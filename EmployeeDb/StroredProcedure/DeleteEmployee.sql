CREATE PROCEDURE [dbo].[DeleteEmployee]
@EmployeeId     INT,
@FirstName      NVARCHAR(50),
@LastName       NVARCHAR(50),
@Designation    NVARCHAR(50),
@Age            INT,
@Salary         INT,
@Gender         NVARCHAR(10)
AS
BEGIN
	DELETE FROM Employee WHERE EmployeeId = @EmployeeId;
END
GO
