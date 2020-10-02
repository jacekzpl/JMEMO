using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security;
using System.ComponentModel.DataAnnotations.Schema;

namespace JMEMO.Models
{
    //[Table("Users")]
    public class User
    {
        public Int64 UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nick { get; set; }
    }
}
