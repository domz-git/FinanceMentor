using System;
using System.ComponentModel.DataAnnotations;
using FinanceMentorTutorial.Shared;

namespace FinanceMentorTutorial.Client.Components
{
    public class ExpenseModel
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        public ExpenseCategory Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
