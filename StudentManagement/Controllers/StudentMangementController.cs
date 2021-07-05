using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Student.Entity.Models;
using Student.Repo.StudentRepo;

namespace StudentManagement.Controllers
{
    public class StudentMangementController : Controller
    {
        private IStudentRepository studentRepository;

        public StudentMangementController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<StudentDetail> model = studentRepository.GetAllStudents().Select(s => new StudentDetail
            {
                StudentId = s.StudentId,
                Name = $"{s.FirstName} {s.LastName}",
                AddedDate = DateTime.Now,
                Email = s.Email
            });
            return View(model);
        }

        [HttpGet]
        public ActionResult AddEditStudent(long? id)
        {
            StudentDetail model = new StudentDetail();
            if (id.HasValue)
            {
                StudentDetail student = studentRepository.GetStudent(id.Value); if (student != null)
                {
                    model.StudentId = student.StudentId;
                    model.FirstName = student.FirstName;
                    model.LastName = student.LastName;
                    model.ModifiedDate = DateTime.Now;
                    model.Email = student.Email;
                }
            }
            return PartialView("~/Views/Student/_AddEditStudent.cshtml", model);
        }
        //[HttpPost]
        //public ActionResult AddEditStudent(long? id, StudentViewModel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            bool isNew = !id.HasValue;
        //            Student student = isNew ? new Student
        //            {
        //                AddedDate = DateTime.UtcNow
        //            } : studentRepository.GetStudent(id.Value);
        //            student.FirstName = model.FirstName;
        //            student.LastName = model.LastName;
        //            student.EnrollmentNo = model.EnrollmentNo;
        //            student.Email = model.Email;
        //            student.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
        //            student.ModifiedDate = DateTime.UtcNow;
        //            if (isNew)
        //            {
        //                studentRepository.SaveStudent(student);
        //            }
        //            else
        //            {
        //                studentRepository.UpdateStudent(student);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult DeleteStudent(long id)
        //{
        //    Student student = studentRepository.GetStudent(id);
        //    StudentViewModel model = new StudentViewModel
        //    {
        //        Name = $"{student.FirstName} {student.LastName}"
        //    };
        //    return PartialView("~/Views/Student/_DeleteStudent.cshtml", model);
        //}
        //[HttpPost]
        //public ActionResult DeleteStudent(long id, FormCollection form)
        //{
        //    studentRepository.DeleteStudent(id);
        //    return RedirectToAction("Index");
        //}
    }
}
