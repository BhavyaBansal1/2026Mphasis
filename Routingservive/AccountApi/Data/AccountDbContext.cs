using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AccountApi.Model;
using System.Linq;
using System.Threading.Tasks;

namespace AccountApi.Data
{
    public class AccountDbContext:DbContext
    {
        public AccountDbContext(DbContextOptions con):base(con){

        }
     public DbSet<Membership> member {get;set;}
    }
}