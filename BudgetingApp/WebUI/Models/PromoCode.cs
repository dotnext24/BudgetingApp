using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class PromoCode
    {
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public decimal Discount { get; set; }
        public bool IsUsed { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

    }
}