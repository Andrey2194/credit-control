using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace credit_control_api.core.Entities
{
    public class Debtor
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Name { get; set; }
        [Required]  
        public bool Active { get; set; }
        public virtual IList<Debt>? Debts { get; set; }
    }
}
