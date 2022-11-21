using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetStopBusStudentController : ControllerBase
    {
        private IGetStopBusStudent _IGetStopBusStudent;
        public GetStopBusStudentController(IGetStopBusStudent IGetStopBusStudent)
        {
            _IGetStopBusStudent = IGetStopBusStudent;
        }

        [HttpGet]
        [Route("GetStopBusWithStudent")]
        public IEnumerable<GetStopBusStudent_Sp> StopBusStudent() 
        {
            var data = _IGetStopBusStudent.StopBusStudent();
            return data;
           
        }

        [HttpGet]
        [Route("getAllBuses")]
        public IEnumerable<LtBusMaster> GetAllBuses()
        {
            using (var local = new LocalTransportationContext())
            {
                return local.LtBusMasters.ToList();
            }
        }

        [HttpGet]
        [Route("getAllCountry")]
        public IEnumerable<LtCountryMaster> GetAllCountry()
        {
            using (var local = new LocalTransportationContext())
            {
                return local.LtCountryMasters.ToList();
            }
        }
    }
}
