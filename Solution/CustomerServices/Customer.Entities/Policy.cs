using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Customer.Entities
{
    public class Policy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PolicyKey { get; set; }
        public int QuoteId { get; set; }
        public DateTime PolicyEffectiveDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public int PolicyTerm { get; set; }
        public string PolicyStatus { get; set; }
    }
}
