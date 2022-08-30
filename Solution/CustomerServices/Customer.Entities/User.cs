using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Customer.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public bool IsRetired { get; set; }
        public bool IsValid { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string UserType { get; set; }
    }
}