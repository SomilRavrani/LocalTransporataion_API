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
    public class StandardMasterController : ControllerBase
    {
        private IStandardMaster _IStandardMaster;
        public StandardMasterController(IStandardMaster IStandardMaster)
        {
            _IStandardMaster = IStandardMaster;
        }

        [HttpGet]
        [Route("GetStandard")]
        public IEnumerable<LtStandardMaster> GetStandard()
        {
            var alldata =  _IStandardMaster.GetStandars();
            return alldata;
        }

    }
}

