using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtDriverMaster
    {
        public LtDriverMaster()
        {
            LtBusMasters = new HashSet<LtBusMaster>();
            LtRouteWiseBusWiseDiverTxns = new HashSet<LtRouteWiseBusWiseDiverTxn>();
        }

        public int DvmId { get; set; }
        public string DvmName { get; set; }
        public DateTime? DvmCreateDate { get; set; }
        public int? DvmCreateBy { get; set; }
        public DateTime? DvmModifyDate { get; set; }
        public int? DvmModifyBy { get; set; }
        public int? DvmStatus { get; set; }

        public virtual ICollection<LtBusMaster> LtBusMasters { get; set; }
        public virtual ICollection<LtRouteWiseBusWiseDiverTxn> LtRouteWiseBusWiseDiverTxns { get; set; }
    }
}
