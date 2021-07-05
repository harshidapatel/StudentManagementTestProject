using System;
using System.Collections.Generic;

#nullable disable

namespace Student.Entity.Models
{
    public partial class StudentGrade : BaseEntity
    {
        public int? Id { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }

        public virtual StudentDetail Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
