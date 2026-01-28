using System;
using System.Collections.Generic;
using System.Linq;
using AccountApi.Data;
using AccountApi.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccountApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        AccountDbContext accountDbContext;

        public AccountController(AccountDbContext _accountDbContext){
            accountDbContext=_accountDbContext;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult CraeteAccount(Membership m){
            accountDbContext.member.Add(m);
            var result=accountDbContext.SaveChanges();
            return Ok(new {
            message="saved record",
            Data=m});
        }
         [HttpPost]
         [Route("Login")]
         public IActionResult LoginAccount(string email,string password){
            var user=accountDbContext.member.FirstOrDefault(u=>u.email == email && u.Password==password);
            if(user==null){
                return Unauthorized(new{
                    message="Invalid email or password"
                });
            }
            return Ok(new {
                message="Login successful",
            user
            });
         }
        
    }
}