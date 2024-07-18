using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace database_project_example.Data
{
    public class EmployeeMst
    {
        [Key]

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeeEmail { get; set; }

        public string EmployeePhone { get; set; }

        public bool status { get; set; }



    }
}
