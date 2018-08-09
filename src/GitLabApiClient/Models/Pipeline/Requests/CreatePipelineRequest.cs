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
        public  IList<VarItem> Variables { get; set; }
    }

    public class VarItem
    {
        [JsonProperty("key")]
        public  string Key { get; set; }
        [JsonProperty("value")]
        public  string Value { get; set; }
    }
}