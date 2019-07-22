// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace CommonLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design;
    using System.Text;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// EmployeeModel class is for set and get employee data 
    /// </summary>
    public class EmployeeModel
    {
        #region Fields
        /// private members 
        private int employeeId;
        private string firstName;
        private string lastName;
        private string designation;
        private string gender;
        private float salary;
        private int age;
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets the EmployeeId.
        /// </summary>
        /// <value>
        /// The EmployeeId.
        /// </value>  
        //[Required(ErrorMessage = "Enter Name")]
        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }
        
        /// <summary>
        /// Gets or sets the Salary.
        /// </summary>
        /// <value>
        /// The Salary.
        /// </value>
        public float Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        /// <summary>
        /// Gets or sets the Age.
        /// </summary>
        /// <value>
        /// The Age.
        /// </value>
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        /// <value>
        /// The FirstName.
        /// </value>
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        /// <value>
        /// The LastName.
        /// </value>
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        /// <summary>
        /// Gets or sets the Designation.
        /// </summary>
        /// <value>
        /// The Designation.
        /// </value>
        public string Designation
        {
            get { return this.designation; }
            set { this.designation = value; }
        }

        /// <summary>
        /// Gets or sets the Gender.
        /// </summary>
        /// <value>
        /// The Gender.
        /// </value>
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        #endregion
    }
}

