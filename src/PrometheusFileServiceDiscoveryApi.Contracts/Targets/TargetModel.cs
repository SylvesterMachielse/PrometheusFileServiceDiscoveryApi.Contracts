using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrometheusFileServiceDiscovery.Contracts.Models
{
    public class TargetModel
    { 
        //<labelname>: a string matching the regular expression [a-zA-Z_][a-zA-Z0-9_]*
        //<labelvalue>: a string of unicode characters
        [JsonProperty("targets")]
        public List<string> Targets { get; set; }
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        public TargetModel()
        {
            Targets = new List<string>();
            Labels = new Dictionary<string, string>();
        }
    }

}