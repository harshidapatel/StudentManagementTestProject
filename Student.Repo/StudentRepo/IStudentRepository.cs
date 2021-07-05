using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Entity.Models;

namespace Student.Repo.StudentRepo
{
    public interface IStudentRepository
    {
        public void SaveStudent(StudentDetail student);
        public IEnumerable<StudentDetail> GetAllStudents();
        public StudentDetail GetStudent(long id);
        public void DeleteStudent(long id);
        public void UpdateStudent(StudentDetail student);
    }
}
