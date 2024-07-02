using BloodDonation.Core.Enums;

namespace BloodDonation.Shared.Forms
{
    public class CreateUserForm
    {
        public CreateUserForm()
        {

        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? LastDonationDate { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public RHFactorEnum RHFactor { get; set; }
        public GenderEnum Gender { get; set; }
        // public CreateAddressCommand? Address { get; set; }

    }
}
