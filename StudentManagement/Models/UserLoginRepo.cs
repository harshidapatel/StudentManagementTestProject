using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class UserLoginRepo
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public bool VerifyLogin(string username, string password)
        {
            bool returnResponse = false;

            if (username == "admin" && password == "admin")
                returnResponse = true;
            return returnResponse;
        }
    }
}
