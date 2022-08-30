using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Admin.Entities
{
    public class Quote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuoteId { get; set; }
        public double Premium { get; set; }
        public double Dwelling { get; set; }
        public double DetachedStructure { get; set; }
        public double PersonalProperty { get; set; }
        public double AdditionalLivingproperty { get; set; }
        public double MedicalExpense { get; set; }
        public double Deductable { get; set; }
        public long UserId { get; set; }
    }
}
