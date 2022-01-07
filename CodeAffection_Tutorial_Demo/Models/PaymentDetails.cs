using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeAffection_Tutorial_Demo.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Required]
        public string CardOwnerName { get; set; }
        
        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string SecurityCode { get; set; }
    }
}
