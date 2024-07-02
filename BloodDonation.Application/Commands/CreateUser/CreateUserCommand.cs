using BloodDonation.Application.Commands.CreateAddress;
using BloodDonation.Core.Entities;
using BloodDonation.Core.Enums;
using BloodDonation.Shared.Forms;
using MediatR;
using System.Data;
using System.Reflection;

namespace BloodDonation.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<BaseResponse<int>>
    {
        public CreateUserCommand(CreateUserForm form)
        {
            FullName = form.FullName;
            Email = form.Email;
            Password = form.Password;
            Role = form.Role;
            BirthDate = form.BirthDate;
            LastDonationDate = form.LastDonationDate;
            BloddType = form.BloodType;
            RHFactor = form.RHFactor;
            Gender = form.Gender;

        }
        public CreateUserCommand(string fullName, 
            string email, 
            string password, 
            string role, 
            DateTime? birthDate, 
            DateTime? lastDonationDate, 
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

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? LastDonationDate { get; set; }
        public BloodTypeEnum BloddType { get; set; }
        public RHFactorEnum RHFactor { get; set; }
        public GenderEnum Gender { get; set; }
        public CreateAddressCommand? Address { get; set; }

    }
}
