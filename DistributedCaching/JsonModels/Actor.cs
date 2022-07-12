using Newtonsoft.Json;
namespace DistributedCaching.JsonModels
{
    public class Actor
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
