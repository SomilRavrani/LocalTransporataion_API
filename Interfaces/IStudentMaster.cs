using LocalTranspotaion_API.Models;
using System.Collections.Generic;

namespace LocalTranspotaion_API.Interfaces
{
    public interface IStudentMaster
    {
        public IEnumerable<LtStudentMaster> GetStudents();

    }
}
