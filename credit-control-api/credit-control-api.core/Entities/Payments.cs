using System.ComponentModel.DataAnnotations;

namespace credit_control_api.core.Entities
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid DebtId { get; set; }
        public virtual Debt? Debt { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public Double Amount { get; set; }
    }
}
