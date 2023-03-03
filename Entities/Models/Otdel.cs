using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Otdel : BaseEntity<int>
    {
        public string Title { get; set; }

        public virtual List<Employ> Employs { get; set; }
    }
}
