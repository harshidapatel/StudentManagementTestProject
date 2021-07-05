using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Entity.Models;

namespace Student.Repo.Subjects
{
    interface ISubjectRepo
    {
        void SaveSubject(Subject student);
        IEnumerable<Subject> GetAllSubject(long studentId);
        Subject GetSubject(long id);
        void DeleteSubject(long id);
        void UpdateSubject(Subject student);
    }
}
