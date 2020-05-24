using MovieBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuzz.ViewModel
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer customer { get; set; }
    }
}