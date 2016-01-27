using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF7Test.Application
{
    public class ServicesService : IServicesService
    {

        private ApplicationDbContext _context;

        public ServicesService(ApplicationDbContext cont)
        {
            _context = cont;
        }

        public IQueryable<Core.Service> GetAllServices()
        {
            return _context.Services.AsQueryable();
        }

        public Core.Service AddService(Core.Service service)
        {
            var dbService = _context.Services.Add(service);
            _context.SaveChanges();
            return dbService.Entity;
        }
    }
}
