using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Praize.Models
{
    public class ResponseHeader
    {
        public ResponseHeader() { }

        public ResponseHeader(string message, EResponseCode responseCode)
        {
            ResponseCode = responseCode;
            Message = message;
        }

        public EResponseCode ResponseCode { get; set; }
        public string Message { get; private set; }
        public bool Successful
        {
            get
            {

                return Errors != null && Errors.Any();
            }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ApiError> Errors { get; private set; }

        #region Public Methods

        public void WithErrors(IEnumerable<ApiError> apiErrors)
        {
            Errors = apiErrors;
        }

        #endregion

    }
}
