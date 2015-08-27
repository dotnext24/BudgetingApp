using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class Payment
    {
        public int ID { get; set; }
        [Required]
        public string PaidBy { get; set; }

        public int? PromocodeID { get; set; }

        public PromoCode Promocode { get; set; }
    }
}