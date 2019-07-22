CREATE PROCEDURE [dbo].[InsertEmployee]
@EmployeeId       INT,
@FirstName        NVARCHAR(50),
@LastName         NVARCHAR(50),
@Designation      NVARCHAR(50),
@Age              INT,
@Salary           INT,
@Gender           NVARCHAR(10)
AS
BEGIN
	INSERT INTO Employee(EmployeeId,
	                     FirstName,
						 LastName,
						 Designation,
						 Age,
						 Salary,
						 Gender)
	            VALUES(@EmployeeId, 
				       @FirstName,
					   @LastName,
					   @Designation,
					   @Age,
					   @Salary,
					   @Gender)
END
GO
