using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Model
{
    public class AccountDbGenerator
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)") ]
        [Required (ErrorMessage = "Empty field")]
        [DisplayName("Email")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Confirm Email")]
        public string EmailConfirmation { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Password { get; set; }

        [DisplayName("Account Type")]
        [Column(TypeName = "varchar(30)")]
        public string AccountType { get; set; }

        [DisplayName("Billing Address")]
        [Column(TypeName = "nvarchar(60)")]
        public string BillingAddress { get; set; }

        [DisplayName("Payment Info")]
        [Column(TypeName = "varchar(30)")]
        public string PaymentInfo { get; set; }

        [DisplayName("Phone Number")]
        [Column(TypeName = "varchar(30)")]
        public string PhoneNumber { get; set; }

        [DisplayName("Register Date")]
        [Column(TypeName = "varchar(30)")]
        public string RegisterDate { get; set; }

        [DisplayName("Login Date")]
        [Column(TypeName = "varchar(30)")]
        public string LoginDate { get; set; }


    }
}
