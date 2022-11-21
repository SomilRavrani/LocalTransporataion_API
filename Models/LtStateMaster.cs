using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtStateMaster
    {
        public LtStateMaster()
        {
            LtCityMasters = new HashSet<LtCityMaster>();
        }

        public int StmId { get; set; }
        public string StmName { get; set; }
        public int? CmId { get; set; }
        public DateTime? StmCreateDate { get; set; }
        public int? StmCreateBy { get; set; }
        public DateTime? StmModifyDate { get; set; }
        public int? StmModifyBy { get; set; }
        public int? StmStatus { get; set; }

        public virtual LtCountryMaster Cm { get; set; }
        public virtual ICollection<LtCityMaster> LtCityMasters { get; set; }
    }
}
