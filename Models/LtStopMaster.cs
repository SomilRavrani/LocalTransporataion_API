using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtStopMaster
    {
        public LtStopMaster()
        {
            LtStopWiseStudentWiseBusWiseTxns = new HashSet<LtStopWiseStudentWiseBusWiseTxn>();
        }

        public int StpId { get; set; }
        public string StpName { get; set; }
        public int? CtmId { get; set; }
        public DateTime? StpCreateDate { get; set; }
        public int? StpCreateby { get; set; }
        public DateTime? StpModifydate { get; set; }
        public int? StpModifyBy { get; set; }
        public int? StpStatus { get; set; }

        public virtual LtCityMaster Ctm { get; set; }
        public virtual ICollection<LtStopWiseStudentWiseBusWiseTxn> LtStopWiseStudentWiseBusWiseTxns { get; set; }
    }
}
