using System.ComponentModel.DataAnnotations;

namespace model_inheritance_practicle_2.data
{
    public class ServiceMst
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
