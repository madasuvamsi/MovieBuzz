using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuzz.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string customerName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


        //Navigation Property
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }




    }
}