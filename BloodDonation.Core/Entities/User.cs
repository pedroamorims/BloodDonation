using BloodDonation.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace BloodDonation.Core.Entities
{
    public class User : IdentityUser<long>
    {
        public User() { }   

        public User(string fullName, string email, string role, BloodTypeEnum bloodType, RHFactorEnum rHFactor, GenderEnum gender, DateTime? birthDate, DateTime? lastDonationDate)
        {
            FullName = fullName;
            Role = role;
            BloodType = bloodType;
            RHFactor = rHFactor;
            Gender = gender;
            BirthDate = birthDate;
            LastDonationDate = lastDonationDate;
            Address = new();
            Email = email;
        }

        public string FullName { get; private set; }
        public string Role { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public DateTime? LastDonationDate { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public RHFactorEnum RHFactor { get; private set; }
        public GenderEnum Gender { get; private set; }
        public List<Address> Address { get; private set; }
        public List<IdentityRole<long>>? Roles { get; set; }

    }
}
