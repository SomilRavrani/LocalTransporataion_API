using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtStandardMaster
    {
        public LtStandardMaster()
        {
            LtStudentMasters = new HashSet<LtStudentMaster>();
        }

        public int StdId { get; set; }
        public string StdName { get; set; }
        public DateTime? StdCreateDate { get; set; }
        public int? StdCreateBy { get; set; }
        public DateTime? StdModifyDate { get; set; }
        public int? StdModifyBy { get; set; }
        public int? StdStatus { get; set; }

        public virtual ICollection<LtStudentMaster> LtStudentMasters { get; set; }
    }
}
