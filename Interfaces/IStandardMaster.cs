using LocalTranspotaion_API.Models;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Interfaces
{
    public interface IStandardMaster
    {
        public IEnumerable<LtStandardMaster> GetStandars();

    }
}
