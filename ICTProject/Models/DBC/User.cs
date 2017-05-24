using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(32)]
        public string Username { get; set; }
        public string Password { get; set; }
        [MaxLength(128)]
        public string FirstName { get; set; }
        [MaxLength(128)]
        public string LastName { get; set; }
        public int Inactive { get; set; }
        public Zone ZoneId { get; set;}
        public Region RegionId { get; set; }
    }
}