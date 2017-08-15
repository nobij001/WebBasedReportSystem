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

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(32)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation of password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is invalid.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(128)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(128)]
        public string LastName { get; set; }

        public Boolean RememberMe { get; set; }
        public Boolean Inactive { get; set; }
        public Zone ZoneId { get; set; }
        public Region RegionId { get; set; }
        public Positions PositionId { get; set; }

    }
}