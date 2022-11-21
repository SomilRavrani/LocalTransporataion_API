using LocalTranspotaion_API.Interfaces;
using LocalTranspotaion_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalTranspotaion_API.Repositories
{
   
    public class StandardRepositories : IStandardMaster
    {
        private LocalTransportationContext _LocalTransportationContext;

        public StandardRepositories(LocalTransportationContext a)
        {
            _LocalTransportationContext = a;
        }
        public IEnumerable<LtStandardMaster> GetStandars()
        {
            var data = _LocalTransportationContext.LtStandardMasters.ToList();
            return data;
        }

    }
}
