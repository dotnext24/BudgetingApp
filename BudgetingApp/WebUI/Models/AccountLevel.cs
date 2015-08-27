using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class AccountLevel
    {
        public int ID { get; set; }

        [Required]
        public string Descriptionn { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int Accounts { get; set; }
    }
}