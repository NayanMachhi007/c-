using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace database_task_21_05_2024.Data
{
    public class ServicesMst
    {
        [Key]

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string ServiceContact { get; set; }

        public string ServiceDate { get; set; }    
    }
}
