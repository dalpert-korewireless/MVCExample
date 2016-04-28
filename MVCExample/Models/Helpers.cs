using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MVCExample.Models
{
    public static class JsonHelpers
    {
        private static JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public static string AsJson(this object src)
        {
            return JsonConvert.SerializeObject(src, Formatting.Indented, _settings);
        }
    }
}