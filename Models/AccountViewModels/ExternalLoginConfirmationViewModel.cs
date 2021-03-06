using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {

        [Required(ErrorMessage = "EMAIL_REQUIRED")]
        [EmailAddress(ErrorMessage = "EMAIL_INVALID")]
        public string Email { get; set; }
    }
}
