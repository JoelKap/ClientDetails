using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDetailManagement.Models
{
    public class UserModel
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}