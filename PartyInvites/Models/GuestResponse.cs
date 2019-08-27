using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please provide your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        [RegularExpression("\\d{10}", ErrorMessage ="Pleaes provide a valid phone number")]
        public string Phone { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
    }
}
