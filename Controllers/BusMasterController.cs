using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusMasterController : ControllerBase
    {

        private IBusMaster _IBusMaster;
        public BusMasterController(IBusMaster IBusMaster)
        {
            _IBusMaster = IBusMaster;
        } 

        [HttpGet]
        public IEnumerable<LtBusMaster> GetBuses()
        {
            return _IBusMaster.GetBuses();
        }
    }
}
