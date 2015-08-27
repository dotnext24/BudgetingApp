using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class Account
    {
        public int ID { get; set; }

        [Required]
        public string MemberID { get; set; }
        [Required]
        public int AccountLabelID { get; set; }
        [Required]
        public decimal MinimumThreshold { get; set; }

        public int PaymentID{get;set;}

        public string AccountName { get; set; }
        [Required]
        public bool IsPrimary { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public string Note { get; set; }

        public ApplicationUser Member { get; set; }
        public AccountLevel AccountLabel { get; set; }
        
    }
}