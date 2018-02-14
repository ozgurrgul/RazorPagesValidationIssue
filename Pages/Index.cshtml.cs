using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesValidationIssue.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string CurrencyId { get; set; }

        [BindProperty]
        public WithdrawalInput WithdrawalInput { get; set; }

        [BindProperty]
        public DepositBankInput DepositBankInput { get; set; }

        public async Task<IActionResult> OnPostWithdrawAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            return RedirectToPage(new {
                currencyId = CurrencyId
            });
        }

        public async Task<IActionResult> OnPostDepositBankAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            return RedirectToPage(new {
                currencyId = CurrencyId
            });
        }
    }
}
