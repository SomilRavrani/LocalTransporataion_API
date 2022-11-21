using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Repositories
{
    public class StudentMasterRepository : IStudentMaster
    {
        private LocalTransportationContext _LocalTransportationContext;        
        public StudentMasterRepository(LocalTransportationContext localTransportationContext)
        {
            _LocalTransportationContext = localTransportationContext;
        }
        public IEnumerable<LtStudentMaster> GetStudents()
        {
            return _LocalTransportationContext.LtStudentMasters.ToList();
        }

    }
}
