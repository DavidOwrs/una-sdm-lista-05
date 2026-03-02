using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Atividade.Models
{
    public class Dados
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }
        [JsonPropertyName("company")]
        public string Empresa { get; set; }
        [JsonPropertyName("location")]
        public string Localizacao { get; set; }
        [JsonPropertyName("login")]
        public string Login { get; set; }
       
    }
}