using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_control_api.core.Entities
{
    public class Debt
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid DebtorId { get; set; }
        public virtual Debtor? Debtor { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public DateTime DealEndDate { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public bool Active { get; set; }
        public virtual IList<Payment>? Payments { get; set; }
    }
}
