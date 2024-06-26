using BloodDonation.Application.Commands.CreateAddress;
using BloodDonation.Core.Enums;
using MediatR;

namespace BloodDonation.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<BaseResponse<int>>
    {
        public CreateUserCommand(string fullName, 
            string email, 
            string password, 
            string role, 
            DateTime birthDate, 
            DateTime lastDonationDate, 
            BloodTypeEnum bloddType, 
            RHFactorEnum rHFactor, 
            GenderEnum gender, 
            CreateAddressCommand? address
            )
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Role = role;
            BirthDate = birthDate;
            LastDonationDate = lastDonationDate;
            BloddType = bloddType;
            RHFactor = rHFactor;
            Gender = gender;
            Address = address;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime LastDonationDate { get; private set; }
        public BloodTypeEnum BloddType { get; private set; }
        public RHFactorEnum RHFactor { get; private set; }
        public GenderEnum Gender { get; private set; }
        public CreateAddressCommand? Address { get; private set; }

    }
}
