using BloodDonation.Application;
using BloodDonation.Shared.Forms;

namespace BloodDonation.Blazor.Services
{
    public class CadastroService
    {
        private readonly HttpClient _httpClient;

        public CadastroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Cadastrar(CreateUserForm command)
        {            
            var response = await _httpClient.PostAsJsonAsync("api/user", command);
            if (response.IsSuccessStatusCode)
            {
                return "Cadastro realizado com sucesso!";
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                return $"Erro ao cadastrar: {errorContent}";
            }
        }

    }
}
