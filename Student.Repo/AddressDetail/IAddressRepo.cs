using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Entity.Models;

namespace Student.Repo.AddressDetail
{
    interface IAddressRepo
    {
        void SaveAddress(StudentAddressDetail student);
        IEnumerable<StudentAddressDetail> GetAllAddresses(long id);
        //StudentAddressDetail GetAddress(long id);
        void DeleteAddress(long id, long studentId);
        void UpdateAddress(StudentAddressDetail student);
    }
}
