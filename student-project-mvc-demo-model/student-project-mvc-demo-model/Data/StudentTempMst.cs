using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace student_project_mvc_demo_model.Data
{
    public class StudentTempMst
    {
        [Key]
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string contactno { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public DateOnly joiningdatae { get; set; }

    }
}
