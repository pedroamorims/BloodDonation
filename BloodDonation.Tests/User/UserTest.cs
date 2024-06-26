using BloodDonation.Application.Commands.CreateUser;
using BloodDonation.Core.Enums;
using BloodDonation.Tests.Repositories;

namespace BloodDonation.Tests.User
{
    public class UserTest
    {
        public UserTest()
        {
            var provider = TestStartup.Provider();
        }

        [Fact]
        public async Task CreateUser()
        {

            var command = new CreateUserCommand(
                "Pedro Henrique Amorim Silva",
                "pedrohenrique.as18@gmail.com",
                "a1b2c3d4",
                "admin",
                new DateTime(1994, 6, 29),
                new DateTime(2020, 6, 29),
                BloodTypeEnum.B,
                RHFactorEnum.Postive,
                GenderEnum.Male,
                null
            );

            var handler = new CreateUserCommandHandler(new UserTestRepository(), new AddressRepository(), new AuthService());
            await handler.Handle(command, CancellationToken.None);
        }




    }
}
