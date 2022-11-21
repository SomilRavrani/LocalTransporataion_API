using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtGenderMaster
    {
        public LtGenderMaster()
        {
            LtStudentMasters = new HashSet<LtStudentMaster>();
        }

        public int GmId { get; set; }
        public string GmName { get; set; }
        public DateTime? GmCreateDate { get; set; }
        public int? GmCreateBy { get; set; }
        public DateTime? GmModifyDate { get; set; }
        public int? GmModifyBy { get; set; }
        public int? GmStatus { get; set; }

        public virtual ICollection<LtStudentMaster> LtStudentMasters { get; set; }
    }
}
