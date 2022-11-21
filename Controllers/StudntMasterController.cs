using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudntMasterController : ControllerBase
    {
        
        private IStudentMaster _IStudentMaster;
        public StudntMasterController(IStudentMaster IStudentMaster)
        {
            _IStudentMaster = IStudentMaster;
        }
        [HttpGet]
        [Route("GetAllSstudent")]
        public IEnumerable<LtStudentMaster> GetStudents()
        {
            return _IStudentMaster.GetStudents();
        }

        [HttpGet]
        [Route("GetAllCities")]
        public IEnumerable<LtStudentMaster> GetAllCities()
        {
            return _IStudentMaster.GetStudents();
        }
    }
}
