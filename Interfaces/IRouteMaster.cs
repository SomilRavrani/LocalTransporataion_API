using LocalTranspotaion_API.Models;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Interfaces
{
    public interface IRouteMaster
    {
        public IEnumerable<LtRouteMaster> GetRoute();

    }
}
