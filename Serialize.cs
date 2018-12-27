using Newtonsoft.Json;

namespace SampleHttpClient
{
    public static class Serialize
    {
        public static string ToJson(this GitHubOrganization[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}