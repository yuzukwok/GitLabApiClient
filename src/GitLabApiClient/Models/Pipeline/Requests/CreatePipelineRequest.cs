using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Pipeline.Requests
{
    public class CreatePipelineRequest
    {
     
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ref")]
        public  string Ref { get; set; }
        
        [JsonProperty("variables")]
        public  IList<KeyValuePair<string,string>> Variables { get; set; }
    }
}