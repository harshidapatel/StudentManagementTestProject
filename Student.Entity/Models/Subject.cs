using System;
using System.Collections.Generic;

#nullable disable

namespace Student.Entity.Models
{
    public partial class Subject : BaseEntity
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public bool? IsActive { get; set; }
    }
}
