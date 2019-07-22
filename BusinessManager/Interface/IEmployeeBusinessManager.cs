﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeBusinessManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessManager.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommonLayer.Model;
    /// <summary>
    /// IEmployeeBusinessManager is 
    /// </summary>
    public interface IEmployeeBusinessManager
    {
        /// <summary>
        /// AddEmployee method declaration is for adding the new Employee in the list 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        void AddEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// DeleteEmployee method declaration is for Deleting the Employee dtat from the list 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        bool DeleteEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// DisplayEmployee method declaration is for displaing the Employee information 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        IList<EmployeeModel> DisplayEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// UpdateEmployee method declaration is for update the new Employee data 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        int UpdateEmployee(EmployeeModel employeeModel);

    }
}