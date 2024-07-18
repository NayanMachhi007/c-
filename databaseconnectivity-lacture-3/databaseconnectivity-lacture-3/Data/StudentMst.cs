using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace databaseconnectivity_lacture_3.Data
{
    public class StudentMst
    {
        [Key]
        public int id { get; set; }
        public  String fname { get; set; }
        public String lname { get; set; }
        public String surname { get; set; }

        public String address { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public DateOnly joiningdate { get; set; } = new DateOnly(2022, 1, 1);





    }
}
