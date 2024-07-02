using BloodDonation.Core.Entities;
using BloodDonation.Core.Repositories;
using BloodDonation.Core.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace BloodDonation.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, BaseResponse<int>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IAuthService _authService;
        private readonly UserManager<User> _userManager;

        public CreateUserCommandHandler(IUserRepository userRepository, IAddressRepository addressRepository, IAuthService authService, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _authService = authService;
            _userManager = userManager;
        }

        public async Task<BaseResponse<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Email, request.Role, request.BloddType, request.RHFactor, request.Gender, request.BirthDate, request.LastDonationDate);
            user.UserName = request.Email;

            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                return BaseResponse<int>.Success(1);
            }
            else
            {
                return BaseResponse<int>.Failure(string.Join(", ", result.Errors.Select(e => e.Description)));
            }

            //var address = new Address(request.Address.Street, request.Address.City, request.Address.State, request.Address.PostalCode, request.Address.Country);

        }
    }
}
