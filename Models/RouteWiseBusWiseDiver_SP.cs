using Microsoft.EntityFrameworkCore;

namespace LocalTranspotaion_API.Models
{
    [Keyless]
    public class RouteWiseBusWiseDiver_SP
    {
        public string  RT_Name { get; set; }
        public string BM_Name { get; set; }
        public string DVM_Name { get; set; }
    } 
}
