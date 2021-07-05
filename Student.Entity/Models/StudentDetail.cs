using System;
using System.Collections.Generic;

#nullable disable

namespace Student.Entity.Models
{
    public partial class StudentDetail : BaseEntity
    {
        public StudentDetail()
        {
            StudentAddressDetails = new HashSet<StudentAddressDetail>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? AddressId { get; set; }

        public virtual ICollection<StudentAddressDetail> StudentAddressDetails { get; set; }
    }
}
