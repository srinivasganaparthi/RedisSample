using Newtonsoft.Json;
namespace DistributedCaching.JsonModels
{
    public class MovieList
    {
        [JsonProperty("cast")]
        public List<Movie> Movies { get; set; }
    }
}
