using BloodDonation.Core.Services;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BloodDonation.Tests.Repositories
{
    public class AuthService : IAuthService
    {
        public string ComputeSha256Hash(string email, string password)
        {
            var concatenado = email + password;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(concatenado));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); //Hexadecimal
                }

                return builder.ToString();
            }
        }

        public string GenerateJwtToken(string email, string role)
        {
            throw new NotImplementedException();
        }
    }
}
