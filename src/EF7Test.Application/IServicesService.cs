using System.Linq;
using EF7Test.Core;

namespace EF7Test.Application
{
    public interface IServicesService
    {
        Service AddService(Service service);
        IQueryable<Service> GetAllServices();
    }
}