using System;
using System.Collections.Generic;

#nullable disable

namespace Student.Entity.Models
{
    public partial class StudentAddressDetail : BaseEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }

        public virtual StudentDetail Student { get; set; }
    }
}
