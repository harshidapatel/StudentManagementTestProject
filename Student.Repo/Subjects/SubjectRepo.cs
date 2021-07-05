using Student.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student.Repo.Subjects
{
    class SubjectRepo : ISubjectRepo
    {
        private StudentManagementContext context;
        private DbSet<Subject> studentEntity;
        public SubjectRepo(StudentManagementContext context)
        {
            this.context = context;
            studentEntity = context.Set<Subject>();
        }
        public void DeleteSubject(long id)
        {
            Subject student = studentEntity.SingleOrDefault(s => s.SubjectId == id);
            student.IsActive = false;
            student.ModifiedDate = DateTime.Now;
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<Subject> GetAllSubject(long studentId)
        {
            return studentEntity.AsEnumerable();
        }

        public Subject GetSubject(long id)
        {
            return studentEntity.SingleOrDefault(s => s.SubjectId == id);
        }

        public void SaveSubject(Subject student)
        {
            context.Entry(student).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateSubject(Subject student)
        {
            context.SaveChanges();
        }
    }
}
