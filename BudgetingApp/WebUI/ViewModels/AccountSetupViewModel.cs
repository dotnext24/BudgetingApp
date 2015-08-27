using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class AccountSetupViewModel
    {
        [Required]
        public string MemberID { get; set; }
        [Required]
        public int AccountLabelID { get; set; }
        [Required]
        public decimal MinimumThreshold { get; set; }

        public string AccountName { get; set; }
        [Required]
        public bool IsPrimary { get; set; }
        [Required]
        
        public DateTime StartDate { get; set; }

        public ApplicationUser Member { get; set; }
        public AccountLevel AccountLabel { get; set; }
    }
}