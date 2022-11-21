using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteMasterController : ControllerBase
    {
        private IRouteMaster _IRouteMaster;
        public RouteMasterController(IRouteMaster IRouteMaster)
        {
            _IRouteMaster = IRouteMaster;
        }
        [HttpGet]
        public IEnumerable<LtRouteMaster> GetRoute()
        {
            return _IRouteMaster.GetRoute();
        }
    }
}
