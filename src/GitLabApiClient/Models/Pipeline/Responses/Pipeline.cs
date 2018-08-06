using System;
using GitLabApiClient.Models.Users.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Pipeline.Responses
{
    public class Pipeline
    {
        [JsonProperty("id")]
        public  int Id { get; set; }
        
        [JsonProperty("sha")]
        public  string Sha { get; set; }
        
        [JsonProperty("ref")]
        public  string Ref { get; set; }
        
        [JsonProperty("status")]
        public  string Status { get; set; }
        
        [JsonProperty("tag")]
        public  string Tag { get; set; }
        
        [JsonProperty("created_at")]
        public  DateTime CreateAt { get; set; }
        
        [JsonProperty("updated_at")]
        public  DateTime UpdateAt { get; set; }
        
        [JsonProperty("started_at")]
        public  DateTime StartedAt { get; set; }
        
        [JsonProperty("finished_at")]
        public  DateTime FinishedAt { get; set; }
        
        [JsonProperty("committed_at")]
        public  DateTime CommittedAt { get; set; }
        
        [JsonProperty("duration")]
        public  string Duration { get; set; }
        
        [JsonProperty("coverage")]
        public  string Coverage { get; set; }
        
        [JsonProperty("web_url")]
        public  string WebUrl { get; set; }
        
        [JsonProperty("user")]
        public  User User { get; set; }
    }
}