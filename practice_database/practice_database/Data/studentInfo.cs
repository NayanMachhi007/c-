using System.ComponentModel.DataAnnotations;

namespace practice_database.Data
{
    public class studentInfo
    {
        [Key]
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string password { get; set; }

    }
}
