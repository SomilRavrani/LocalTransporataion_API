using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Repositories
{
    public class RouteMasterRepositrories : IRouteMaster
    {
        private LocalTransportationContext _LocalTransportationContext;
        public RouteMasterRepositrories(LocalTransportationContext LocalTransportationContext)
        {
            _LocalTransportationContext  = LocalTransportationContext ;
        }
        public IEnumerable<LtRouteMaster> GetRoute()
        {
            return _LocalTransportationContext.LtRouteMasters.ToList();
        }
    }
}
