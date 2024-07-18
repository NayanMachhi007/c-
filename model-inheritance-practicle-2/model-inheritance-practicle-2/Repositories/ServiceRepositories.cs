using model_inheritance_practicle_2.data;
using model_inheritance_practicle_2.Data;
using model_inheritance_practicle_2.Models;

namespace model_inheritance_practicle_2.Repositories
{
    public class ServiceRepositories
    {
        private readonly DataContext _datacontext;


        public ServiceRepositories(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<ServiceModelList> Services()
        {
            List<ServiceModelList> services = new List<ServiceModelList>();

            var data = _datacontext.ServiceMsts.ToList();
            foreach (var iteam in data) {

                ServiceModelList servicemodel = new ServiceModelList()
                {
                    id = iteam.id,
                    name = iteam.name,
                };     
                services.Add(servicemodel);
            }
            return services;
        }


        public void Serviceadd(ServiceModelList serviceselist)
        {

            ServiceMst service = new ServiceMst()
            {
                    name = serviceselist.name,
            };
            _datacontext.ServiceMsts.Add(service);
            _datacontext.SaveChanges();

        }
    }
}
