using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zippersale.Models
{
    public class UserRegister
    {
        [Key]
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone2 { get; set; }
        public string Phone1 { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public bool Sex { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime Birthday { get; set; }
        public string Identity { get; set; }
        public string RG { get; set; }
        


        public string Password { get; set; }
    }
}