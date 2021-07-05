using Student.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student.Repo.GradeDetail
{
    class GradeRepo : IGradeRepo
    {
        private StudentManagementContext context;
        private DbSet<StudentGrade> studentEntity;
        public GradeRepo(StudentManagementContext context)
        {
            this.context = context;
            studentEntity = context.Set<StudentGrade>();
        }

        public void DeleteGrade(long id, long studentId)
        {
            StudentGrade student = GetGrade(id, studentId);
            studentEntity.Remove(student);
            context.SaveChanges();
        }
        public StudentGrade GetGrade(long id, long studentId)
        {
            return studentEntity.SingleOrDefault(s => s.Id == id && s.StudentId == studentId);
        }
        public IEnumerable<StudentGrade> GetAllGrade(long studentId)
        {
            return studentEntity.Where(s => s.StudentId == studentId).AsEnumerable();
        }

        public void SaveGrade(StudentGrade student)
        {
            context.Entry(student).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateGrade(StudentGrade student)
        {
            context.SaveChanges();
        }
    }
}
