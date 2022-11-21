using LocalTranspotaion_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private LocalTransportationContext _LocalTransportationContext;
        public StateController(LocalTransportationContext localTransportationContext)
        {
            _LocalTransportationContext = localTransportationContext;
        }

        [HttpGet]
        [Route("getAllState")]
        public IEnumerable<LtStateMaster> Sum()
        {
            using (var local = new LocalTransportationContext())
            {
                return local.LtStateMasters.ToList();
            }
        }
    }
}
