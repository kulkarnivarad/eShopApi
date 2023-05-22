using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eShopApi.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Tstatus { get; set; }
        public string Mode { get; set; }
      
        public string Email { get; set; }
    }
}
