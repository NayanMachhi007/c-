using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace curdoperationdemo.Data
{
    public class EmployeeMst
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public  string surname { get; set; }

        public string address { get; set; }

        public string permentaddress { get; set; }

        public string contactno { get; set; }

        public string  emailaddress { get; set; }

        public string password { get; set; }

        public DateOnly joiningdate { get; set; }
      
    }
}
