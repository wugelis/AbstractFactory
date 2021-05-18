using Application;
using System;

namespace Infrastructure
{
    public class ServiceFactory : IServiceFactory
    {
        public IService makeSvc()
        {
            IService service = new ConcreteImpl();
            return service;
        }
    }
}
