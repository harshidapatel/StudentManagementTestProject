using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student.Entity.Models;

namespace Student.Repo.StudentRepo
{
    public class StudentRepository : IStudentRepository
    {
        private StudentManagementContext context;
        private DbSet<StudentDetail> studentEntity;
        public StudentRepository(StudentManagementContext context)
        {
            this.context = context;
            studentEntity = context.Set<StudentDetail>();
        }


        public void SaveStudent(StudentDetail student)
        {
            context.Entry(student).State = EntityState.Added;
            context.SaveChanges();
        }

        public IEnumerable<StudentDetail> GetAllStudents()
        {
            return studentEntity.AsEnumerable();
        }

        public StudentDetail GetStudent(long id)
        {
            return studentEntity.SingleOrDefault(s => s.StudentId == id);
        }
        public void DeleteStudent(long id)
        {
            StudentDetail student = GetStudent(id);
            studentEntity.Remove(student);
            context.SaveChanges();
        }
        public void UpdateStudent(StudentDetail student)
        {
            context.SaveChanges();
        }
      
    }
}
