using Newtonsoft.Json;
namespace DistributedCaching.JsonModels
{
    public class Movie
    {

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
