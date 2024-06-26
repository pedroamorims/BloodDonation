using BloodDonation.Core.Entities;
using BloodDonation.Core.Repositories;
using BloodDonation.Core.Services;
using MediatR;

namespace BloodDonation.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, BaseResponse<int>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IAuthService _authService;

        public CreateUserCommandHandler(IUserRepository userRepository, IAddressRepository addressRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _authService = authService;
        }

        public async Task<BaseResponse<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var senhaHash = _authService.ComputeSha256Hash(request.Email, request.Password);

            var user = new User(request.FullName, request.Email, request.Password, request.Role, request.BloddType, request.RHFactor, request.Gender, request.BirthDate, request.LastDonationDate);

            await _userRepository.AddAsync(user);

            return BaseResponse<int>.Success(user.Id);

            //var address = new Address(request.Address.Street, request.Address.City, request.Address.State, request.Address.PostalCode, request.Address.Country);

        }
    }
}
