using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FS_System.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; } 
        public string Password { get; set; }
        public int UserType { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UpdatedDate { get; set; }
    }
}
