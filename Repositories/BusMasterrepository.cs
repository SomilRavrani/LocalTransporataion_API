using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Repositories
{
    public class BusMasterrepository : IBusMaster
    {

        private LocalTransportationContext _LocalTransportationContext;
        public BusMasterrepository(LocalTransportationContext localTransportationContext)
        {
            _LocalTransportationContext = localTransportationContext;
        }

        public IEnumerable<LtCountryMaster> GetAllContries()
        {
            return _LocalTransportationContext.LtCountryMasters.ToList();

        }

        public IEnumerable<LtBusMaster> GetBuses()
        {
            return _LocalTransportationContext.LtBusMasters.ToList();
        }
       
    }
}
