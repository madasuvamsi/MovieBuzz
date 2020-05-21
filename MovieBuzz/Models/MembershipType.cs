using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuzz.Models
{
    public class MembershipType
    {
        public short Id { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte Discount { get; set; }

        public string MembershipName { get; set; }

    }
}