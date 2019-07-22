// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeRepositoryService.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryManager.Services
{
    using System;
    using System.Collections.Generic;
    using CommonLayer.Model;
    using System.Linq;
    using System.Text;
    using System.Web;
    using System.Data;
    using RepositoryManager.Interface;
    using System.Data.SqlClient;

    /// <summary>
    /// 
    /// </summary>
    public class EmployeeRepositoryService : IEmployeeRepository
    {
        private static object Configuaration;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=EmployeeDb;Integrated Security=True");

        /// <summary>
        /// AddEmployee method is for adding the new Employee in the list 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        public int AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("EmployeeProcedure", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@EmployeeId", employeeModel.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("@Designation", employeeModel.Designation);
                sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);
                sqlCommand.Parameters.AddWithValue("@Age", employeeModel.Age);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
            return 0;
        }

        public bool DeleteEmployee(EmployeeModel employeeModel)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteEmployee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@EmployeeId", employeeModel.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@FirstName", null);
                sqlCommand.Parameters.AddWithValue("@LastName", null);
                sqlCommand.Parameters.AddWithValue("@Designation", null);
                sqlCommand.Parameters.AddWithValue("@Salary", null);
                sqlCommand.Parameters.AddWithValue("@Age", null);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public IList<EmployeeModel> DisplayEmployee(EmployeeModel employeeModel)
        {
            // create a command object
            SqlCommand sqlCommand = new SqlCommand("GetEmployee", sqlConnection);
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader dataReader = null;
            try
            {
                sqlConnection.Open();
                //IList for storing the data into the EmployeeList
                IList<EmployeeModel> employeeList = null;
                //get an instance of an sqlDataReader
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    employeeModel.EmployeeId = (int)dataReader["EmployeeId"];
                    employeeModel.FirstName = dataReader["FirstName"].ToString();
                    employeeModel.LastName = dataReader["LastName"].ToString();
                    employeeModel.Designation = dataReader["Designation"].ToString();
                    employeeModel.Salary = (float)dataReader["Salary"];
                    employeeModel.Age = (int)dataReader["Age"];
                }
                
                //stored all data into the employeeList
                employeeList.Add(employeeModel);

                return employeeList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(dataReader!=null)
                {
                    dataReader.Close();
                }
                if(sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int UpdateEmployee(EmployeeModel employeeModel)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateEmployee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@EmployeeId", employeeModel.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("@Designation", employeeModel.Designation);
                sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);
                sqlCommand.Parameters.AddWithValue("@Age", employeeModel.Age);
                sqlConnection.Open();
                return 0;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }

    
}
