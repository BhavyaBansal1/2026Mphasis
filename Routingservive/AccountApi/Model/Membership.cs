using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccountApi.Model
{
    public class Membership
    {
        [Key]
        public int Id{get;set;}
        public string? username{get;set;}
        public string? Password {get;set;}
        public string? email { get; set; }
    }
}