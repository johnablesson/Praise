using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Praize.Models
{
    public class ApiError : IApiError
    {
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }
    }
}
