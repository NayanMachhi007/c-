namespace model_inheritance_practicle_2.Models
{
    public class ServiceModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ServiceModelList : ServiceModel{
        public List<ServiceModelList> serviceList { get; set; }

        }
}
