using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Entity.Models
{
    public class BaseEntity
    {
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
            public DateTime ModifiedDate { get; set; }
    }
}
