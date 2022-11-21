using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Repositories
{
    public class RouteWiseBusWiseDiverRepositries : IRouteWiseBusWiseDiver
    {
        private LocalTransportationContext _LocalTransportationContext;
        public RouteWiseBusWiseDiverRepositries(LocalTransportationContext localTransportationContext)
        {
            _LocalTransportationContext = localTransportationContext;
        }
        public IEnumerable<RouteWiseBusWiseDiver_SP> _RouteWiseBusWiseDiver_SP()
        {
            return _LocalTransportationContext.RouteWiseBusWiseDiverSP.FromSqlInterpolated($"EXEC RouteWiseBusWiseDiver_SP");
        }
    }
}
