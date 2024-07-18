using System.ComponentModel.DataAnnotations;

namespace test_curd_operation_30_05_2024.Data
{
    public class Emptesttable
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
    }
}
