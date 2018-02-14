using System.ComponentModel.DataAnnotations;

namespace RazorPagesValidationIssue.Pages
{
    public class DepositBankInput
    {
        [Required(ErrorMessage = "DepositBankInput amount validation")]
        [Range(0, float.MaxValue, ErrorMessage = "DepositBankInput amount range validation")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "DepositBankInput SelectedSystemBankAccountId validation")]
        public int SelectedSystemBankAccountId { get; set; }
    }
}