using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Make
{
    public class MakeHandler
    {
        private readonly IServiceFactory _serviceFactory;

        public MakeHandler(IServiceFactory serviceFactory)
        {
            this._serviceFactory = serviceFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IService MakeService()
        {
            IService service = _serviceFactory.makeSvc();
            return service;
        }
    }
}
