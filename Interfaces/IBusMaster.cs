using LocalTranspotaion_API.Models;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Interfaces
{

    public interface IBusMaster
    {
        public IEnumerable<LtBusMaster> GetBuses();

    }
}
