using System;
using System.Collections.Generic;
using System.Text;

namespace Praise.Contracts
{
    public class LoginResponseContract
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
