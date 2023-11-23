using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTAuthManager.Model
{
    public class AuthenResponse
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public int ExpireIn { get; set; }
    }
}
