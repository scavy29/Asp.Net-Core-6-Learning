using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        /* Made transaction id as primary key*/
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName="nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required]
        public string Accountnumber { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Benificiary Name")]
        [Required]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Bank Name")]
        [Required]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("IFSC")]
        [Required]
        public string IFSCCode { get; set; }

        [Required]
        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
