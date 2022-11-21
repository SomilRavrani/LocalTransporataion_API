using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtCityMaster
    {
        public LtCityMaster()
        {
            LtStopMasters = new HashSet<LtStopMaster>();
        }

        public int CtmId { get; set; }
        public string CtmName { get; set; }
        public int? StmId { get; set; }
        public DateTime? CtmCreateDate { get; set; }
        public int? CtmCreateBy { get; set; }
        public DateTime? CtmModifyDate { get; set; }
        public int? CtmModifyBy { get; set; }
        public int? CtmStatus { get; set; }

        public virtual LtStateMaster Stm { get; set; }
        public virtual ICollection<LtStopMaster> LtStopMasters { get; set; }
    }
}
