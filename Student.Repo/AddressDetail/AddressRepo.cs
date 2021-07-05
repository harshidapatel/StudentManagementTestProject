using Student.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Student.Repo.AddressDetail
{
    class AddressRepo : IAddressRepo
    {
        private StudentManagementContext context;
        private DbSet<StudentAddressDetail> studentEntity;
        public AddressRepo(StudentManagementContext context)
        {
            this.context = context;
            studentEntity = context.Set<StudentAddressDetail>();
        }
        public void DeleteAddress(long id, long studentId)
        {
            StudentAddressDetail student = GetAddress(id, studentId);
            studentEntity.Remove(student);
            context.SaveChanges();
        }

        public StudentAddressDetail GetAddress(long id ,long studentId)
        {
            return studentEntity.SingleOrDefault(s => s.Id == id && s.StudentId == studentId);
        }

        public IEnumerable<StudentAddressDetail> GetAllAddresses(long id)
        {
            return studentEntity.Where(s => s.StudentId == id).AsEnumerable();
        }

        public void SaveAddress(StudentAddressDetail student)
        {
            context.Entry(student).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateAddress(StudentAddressDetail student)
        {
            context.SaveChanges();
        }
    }
}
