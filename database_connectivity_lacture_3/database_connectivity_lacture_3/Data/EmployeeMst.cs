using System.ComponentModel.DataAnnotations;

namespace database_connectivity_lacture_3.Data
{
    public class EmployeeMst
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
