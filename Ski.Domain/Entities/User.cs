using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski.Domain.Entities
{
    class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Mail { get; set; }
        public String Phone { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Adress { get; set; }
        public String Birthday { get; set; }
        public String Role { get; set; }
        public Boolean Enabled { get; set; }
        public String Image { get; set; }
    }
}
