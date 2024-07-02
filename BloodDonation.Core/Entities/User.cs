using BloodDonation.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, string password, string role, BloodTypeEnum bloodType, RHFactorEnum rHFactor, GenderEnum gender, DateTime? birthDate, DateTime? lastDonationDate)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Role = role;
            BloodType = bloodType;
            RHFactor = rHFactor;
            Gender = gender;
            BirthDate = birthDate;
            LastDonationDate = lastDonationDate;
            Address = new();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public DateTime? LastDonationDate { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public RHFactorEnum RHFactor { get; private set; }
        public GenderEnum Gender { get; private set; }
        public List<Address> Address { get; private set; }





    }
}
