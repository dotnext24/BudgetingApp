using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebUI.Models;


namespace WebUI.ViewModels
{
    public class ReceivePaymentViewModel
    {
        [Required]
        public decimal Amount { get; set; }
        public AccountLevel AccountLevel { get; set; }
        public string PaymentMethod { get; set; }
        public bool UsePromoCode { get; set; }       
        public string PromoCode { get; set; }
    
    }
}