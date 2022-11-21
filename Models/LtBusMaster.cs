using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtBusMaster
    {
        public LtBusMaster()
        {
            LtRouteWiseBusWiseDiverTxns = new HashSet<LtRouteWiseBusWiseDiverTxn>();
            LtStopWiseStudentWiseBusWiseTxns = new HashSet<LtStopWiseStudentWiseBusWiseTxn>();
        }

        public int BmId { get; set; }
        public string BmName { get; set; }
        public string BmNumber { get; set; }
        public int? DvmId { get; set; }
        public DateTime? BmCreateDate { get; set; }
        public int? BmCreateBy { get; set; }
        public DateTime? BmModifyDate { get; set; }
        public int? BmModifyBy { get; set; }
        public int? BmStatus { get; set; }

        public virtual LtDriverMaster Dvm { get; set; }
        public virtual ICollection<LtRouteWiseBusWiseDiverTxn> LtRouteWiseBusWiseDiverTxns { get; set; }
        public virtual ICollection<LtStopWiseStudentWiseBusWiseTxn> LtStopWiseStudentWiseBusWiseTxns { get; set; }
    }
}
