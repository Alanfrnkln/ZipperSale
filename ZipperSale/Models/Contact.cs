using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zippersale.Models
{
    public class Contact
    {
        [Key] public int ContactID { get; set; }     
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ContactDate { get; set; }
        public Boolean Response { get; set; }
        public DateTime ResponseDate { get; set; }
    }
}