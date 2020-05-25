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
        [Display(Name ="Customer Name")]
        public string customerName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


        ////Navigation Property
        public MembershipType MembershipType { get; set; }

        [Display(Name ="Membership Type")]
        public short MembershipTypeId { get; set; }

        [Display(Name ="Date of Birth")]
        [MoreThan18Years]
        public DateTime? Birthday { get; set; }


      
    }
}