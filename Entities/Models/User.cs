using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User:BaseEntity<int>
    {
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DataBirth { get; set; }
        public string Paspord { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string Naznachen { get; set; }
    }
}
