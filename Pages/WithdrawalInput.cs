using System.ComponentModel.DataAnnotations;

namespace RazorPagesValidationIssue.Pages
{
    public class WithdrawalInput
    {
        [Required(ErrorMessage = "WithdrawalInput address validation")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required(ErrorMessage = "WithdrawalInput amount validation")]
        public decimal Amount { get; set; }
    }
}