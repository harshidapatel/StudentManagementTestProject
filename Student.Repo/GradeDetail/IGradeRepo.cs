using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Entity.Models;


namespace Student.Repo.GradeDetail
{
    interface IGradeRepo
    {
        void SaveGrade(StudentGrade student);
        IEnumerable<StudentGrade> GetAllGrade(long studentId);
        //StudentGrade GetAddress(long id);
        //void DeleteGrade(long id,long studentId);
        void UpdateGrade(StudentGrade student);
    }
}
