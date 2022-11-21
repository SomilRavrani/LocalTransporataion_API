using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LocalTranspotaion_API.Models
{
    [Keyless]
    public class GetStopBusStudent_Sp
    {
        public string SM_Name { get; set; }
        public string BusName { get; set; }
        public string StopName { get; set; }
    }
}


