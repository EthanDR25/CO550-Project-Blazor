using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Blazor.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [BindProperty, Required]
        public string BookingDate { get; set; }

        [BindProperty, Required]
        public string CardNumber { get; set; }

        [BindProperty, Required]
        public string CardName { get; set; }

        [BindProperty, Required]
        public int SecurityNumber { get; set; }

        [BindProperty, Required]
        public string ExpiryDate { get; set; }

        public HttpResponse response { get; set; }

        public void OnGet()
        {

        }

        public void PageRedirect()
        {
            response.Redirect("PaymentPage.cshtml");
        }
        public void OnPost()
        {
            Console.WriteLine(CardName);
            Console.WriteLine(CardNumber);
            Console.WriteLine(BookingDate);
            Console.WriteLine(SecurityNumber);
            Console.WriteLine(ExpiryDate);
        }
    }
}
