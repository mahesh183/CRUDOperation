// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using BusinessManager.Interface;
    using CommonLayer.Model;
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeBusinessManager employeeBusinessManager;

        public EmployeeController(IEmployeeBusinessManager employeeBusinessManager)
        {
            this.employeeBusinessManager = employeeBusinessManager;
        }

        // GET: api/E
        [HttpGet]
        public IEnumerable<EmployeeModel> GetDetails()
        {
           // return new string[] { "value1", "value2" };
        }

        // GET: api/E/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/E
        [HttpPost]
        public void Add([FromBody] string value)
        {
        }

        // PUT: api/E/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
