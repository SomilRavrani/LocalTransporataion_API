using LocalTranspotaion_API.Models;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Interfaces
{
    public interface IGetStopBusStudent
    {
        public IEnumerable<GetStopBusStudent_Sp> StopBusStudent();
        public IEnumerable<LtBusMaster> GetAllBuses();
        public IEnumerable<LtCountryMaster> GetAllCountry();
    }
}
