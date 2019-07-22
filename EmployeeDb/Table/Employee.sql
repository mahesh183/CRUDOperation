CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Designation] NVARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    [Salary] DECIMAL NOT NULL, 
    [Gender] NCHAR(10) NOT NULL
)
