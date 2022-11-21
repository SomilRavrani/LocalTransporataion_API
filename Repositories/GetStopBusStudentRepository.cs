using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Repositories
{
    public class GetStopBusStudentRepository : IGetStopBusStudent
    {
        private LocalTransportationContext _LocalTransportationContext;
        public GetStopBusStudentRepository(LocalTransportationContext localTransportationContext)
        {
            _LocalTransportationContext = localTransportationContext;
        }
        public IEnumerable<LtBusMaster> GetAllBuses()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LtCountryMaster> GetAllCountry()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GetStopBusStudent_Sp> StopBusStudent()
        {
            var data = _LocalTransportationContext.GetStopBusStudent_Sp.FromSqlInterpolated($"Exec GetStopBusStudent");
            return data;
        }
    }
}
