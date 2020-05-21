using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBuzz.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string customerName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


        ////Navigation Property
        public MembershipType MembershipType { get; set; }

        public short MembershipTypeId { get; set; }

        public DateTime? Birthday { get; set; }
    }
}