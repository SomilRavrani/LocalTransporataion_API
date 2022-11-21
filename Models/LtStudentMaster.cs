using System;
using System.Collections.Generic;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LtStudentMaster
    {
        public LtStudentMaster()
        {
            LtStopWiseStudentWiseBusWiseTxns = new HashSet<LtStopWiseStudentWiseBusWiseTxn>();
        }

        public int SmId { get; set; }
        public string SmName { get; set; }
        public string SmPhoneNumber { get; set; }
        public string SmAddress { get; set; }
        public int? GmId { get; set; }
        public int? StdId { get; set; }

        public virtual LtGenderMaster Gm { get; set; }
        public virtual LtStandardMaster Std { get; set; }
        public virtual ICollection<LtStopWiseStudentWiseBusWiseTxn> LtStopWiseStudentWiseBusWiseTxns { get; set; }
    }
}
