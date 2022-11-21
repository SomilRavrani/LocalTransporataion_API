using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteWiseBusWiseDiverController : ControllerBase
    {
        private IRouteWiseBusWiseDiver _IRouteWiseBusWiseDiver;

        public RouteWiseBusWiseDiverController(IRouteWiseBusWiseDiver IRouteWiseBusWiseDiver)
        {
            _IRouteWiseBusWiseDiver = IRouteWiseBusWiseDiver;
        }
        [HttpGet]
        public IEnumerable<RouteWiseBusWiseDiver_SP> _RouteWiseBusWiseDiver_SP()
        {
            return _IRouteWiseBusWiseDiver._RouteWiseBusWiseDiver_SP();
        }
    }
}
