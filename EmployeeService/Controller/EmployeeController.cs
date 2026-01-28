using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeService.Model;
using EmployeeService.Repostiory;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    { IEmployeeRepository i;

        public EmployeeController(IEmployeeRepository _i){
            i=_i;
        }


        [HttpGet]
        [Route("Fetch")]
        public IActionResult GetEmployee()
        {   var x=i.GetAll();
            return Ok(x);
        }
       [HttpPost]
       [Route("Add")]
         public IActionResult Create(Employee e)
        {   var data=i.CreateEmployee(e);
            return Ok(data);
        }
         [HttpPut]
         public IActionResult Update(int Id ,Employee e)
        {
           var temp=i.UpdateEmployee(Id,e);
            return Ok(temp);            
        }
        [HttpDelete]
        [Route("DeleteById")]
         public IActionResult Delete(int Id)
        {
            var temp=i.DeleteEmployee(Id);
            return Ok(temp);            
        }
        [HttpGet]
        [Route("search")]
         public IActionResult SearchById(int Id)
        {
            var temp=i.GetSearchbyId(Id);
            return Ok(temp);     
        }
    }
}