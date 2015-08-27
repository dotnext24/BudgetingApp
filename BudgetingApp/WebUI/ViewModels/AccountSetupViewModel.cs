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
        public int AccountLabelID { get; set; }
        [Required]
        public decimal MinimumThreshold { get; set; }

        [Required]
        public string AccountName { get; set; }
       
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public ApplicationUser Member { get; set; }
        public AccountLevel AccountLabel { get; set; }
    }
}