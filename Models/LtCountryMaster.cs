using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtCountryMaster
    {
        public LtCountryMaster()
        {
            LtStateMasters = new HashSet<LtStateMaster>();
        }

        public int CmId { get; set; }
        public string CmName { get; set; }
        public DateTime? CmCreateDate { get; set; }
        public int? CmCreateBy { get; set; }
        public DateTime? CmModifyDate { get; set; }
        public int? CmModifyBy { get; set; }
        public int? CmStatus { get; set; }

        public virtual ICollection<LtStateMaster> LtStateMasters { get; set; }
    }
}
