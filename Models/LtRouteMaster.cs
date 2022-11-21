using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtRouteMaster
    {
        public LtRouteMaster()
        {
            LtRouteWiseBusWiseDiverTxns = new HashSet<LtRouteWiseBusWiseDiverTxn>();
        }

        public int RtId { get; set; }
        public string RtName { get; set; }
        public DateTime? RtCreateDate { get; set; }
        public int? RtCreateBy { get; set; }
        public DateTime? RtModifyDate { get; set; }
        public int? RtModifyBy { get; set; }
        public int? RtStatus { get; set; }

        public virtual ICollection<LtRouteWiseBusWiseDiverTxn> LtRouteWiseBusWiseDiverTxns { get; set; }
    }
}
