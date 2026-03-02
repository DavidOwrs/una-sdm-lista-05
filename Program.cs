using System.Net.Http.Headers;
using static System.Console;

WriteLine("Digite o usuario para consulta: ");
string info = ReadLine();

string url = $"https://api.github.com/user/{info}";

WriteLine($"Consultando o usuario: {info}...");

try
{
    using var client = new HttpClient();

    client.DefaultRequestHeaders.Add("User-agent", "David");

    var response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();
    
    var content = await response.Content.ReadAsStringAsync();

    var Dados = System.Text.Json.JsonSerializer.Deserialize<Atividade.Models.Dados>(content);

    if (Dados != null)
    {
        WriteLine($"Nome: {Dados.Nome}");
        WriteLine($"Empresa: {Dados.Empresa}");
        WriteLine($"Localização: {Dados.Localizacao}");
        WriteLine($"Login: {Dados.Login}");
          
    }
    else
    {
        WriteLine("Informações não encontradas.");
    }

}
catch (Exception ex)
{
    WriteLine($"Erro ao consultar informações: {ex.Message}");
}