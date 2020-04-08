using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Model
{
    public class AccountDbGenerator
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public string BillingAddress { get; set; }
        public string PaymentInfo { get; set; }
        public string PhoneNumber { get; set; }
        public string RegisterDate { get; set; }



    }
}
