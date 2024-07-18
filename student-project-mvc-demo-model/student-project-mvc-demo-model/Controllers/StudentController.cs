using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using student_project_mvc_demo_model.Data;
using student_project_mvc_demo_model.Models;

namespace student_project_mvc_demo_model.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext _dataContext;

        public StudentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
           List<StudentModel> studentModelsList = new List<StudentModel>();

            var data = _dataContext.TempMst.ToList();
            
            foreach(var iteam in data)
            {
              StudentModel studentModel = new StudentModel();

                studentModel.id = iteam.id;
                studentModel.fname = iteam.fname;
                studentModel.lname = iteam.lname;
                studentModel.surname = iteam.surname;
                studentModel.address = iteam.address;
                studentModel.contactno = iteam.contactno;
                studentModel.email = iteam.email;
                studentModel.password=iteam.password;
                studentModel.confirmpassword= iteam.confirmpassword;
                studentModel.joiningdatae = iteam.joiningdatae;             
                
                studentModelsList.Add(studentModel);
            }
      
            return View(studentModelsList);
        }

        [HttpGet]
        public IActionResult studentadd()
        {
           
            return View();
        }


        [HttpPost]
        public IActionResult studentadd(StudentModel student)
        {
            StudentTempMst studentTempMst = new StudentTempMst()
            { 
                id = student.id,
                fname = student.fname,
                lname = student.lname,
                surname = student.surname,
                address = student.address,
                contactno = student.contactno,
                email = student.email,
                password = student.password,
                confirmpassword = student.confirmpassword,
                joiningdatae = student.joiningdatae,
            };

            _dataContext.TempMst.Add(studentTempMst);
            _dataContext.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult studentedit(int id)
        {
            var newdata = _dataContext.TempMst.Find(id);
            return View(newdata);
        }


        [HttpPost]
        public IActionResult studentedit(StudentTempMst student)
        {
            _dataContext.TempMst.Update(student);
            _dataContext.SaveChanges();
            return RedirectToAction("studentedit");
        }
    }
}
