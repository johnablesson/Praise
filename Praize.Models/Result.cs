using System;
using System.Linq;

namespace Praize.Models
{
    public class ApiResult<T> 
    {
        public T Data { get; set; }
        public ResponseHeader Header { get; set; }

        public ApiResult<T> Create(string message, EResponseCode responseCode, T data)
        {
            return new ApiResult<T>()
            {
                Header = new ResponseHeader(message, responseCode),
                Data = data
            };
        }
    }
}
