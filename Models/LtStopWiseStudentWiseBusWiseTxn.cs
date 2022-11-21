using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtStopWiseStudentWiseBusWiseTxn
    {
        public int SwsId { get; set; }
        public int? SmId { get; set; }
        public int? StpId { get; set; }
        public int? BmId { get; set; }

        public virtual LtBusMaster Bm { get; set; }
        public virtual LtStudentMaster Sm { get; set; }
        public virtual LtStopMaster Stp { get; set; }
    }
}
