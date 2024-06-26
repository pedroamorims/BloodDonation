using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Core.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(string email, string role);

        string ComputeSha256Hash(string email, string password);
    }
}
