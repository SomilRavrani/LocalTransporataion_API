using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtRouteWiseBusWiseDiverTxn
    {
        public int RbdId { get; set; }
        public int? RtId { get; set; }
        public int? BmId { get; set; }
        public int? DvmId { get; set; }
        public DateTime? RbdCreateDate { get; set; }
        public int? RbdCreateBy { get; set; }
        public DateTime? RbdModifyDate { get; set; }
        public int? RbdModifyBy { get; set; }
        public int? RbdStatus { get; set; }

        public virtual LtBusMaster Bm { get; set; }
        public virtual LtDriverMaster Dvm { get; set; }
        public virtual LtRouteMaster Rt { get; set; }
    }
}
