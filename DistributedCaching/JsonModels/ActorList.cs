using Newtonsoft.Json;
namespace DistributedCaching.JsonModels
{
    public class ActorList
    {
        [JsonProperty("results")]
        public List<Actor> Actors { get; set; }
    }
}
