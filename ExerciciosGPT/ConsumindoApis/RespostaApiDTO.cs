

using System.Text.Json.Serialization;

namespace ObjetosWebApi.ConsumindoApis
{
    public class RespostaApiDTO

    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}
