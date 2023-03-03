using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employ:BaseEntity<Guid>
    {
        public string FIO { get; set; }
        public int? DeptId { get; set; }
        public int? OtdelId { get; set; }

    }
}
