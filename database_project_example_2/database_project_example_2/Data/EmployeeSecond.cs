using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace database_project_example_2.Data
{
    public class EmployeeSecond
    {
        [Key]
        public int empid { get; set; }

        public string empname { get; set; }

        public string empemail { get; set; }
    }
}
