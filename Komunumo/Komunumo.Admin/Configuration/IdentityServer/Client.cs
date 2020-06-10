using System.Collections.Generic;
using Komunumo.Admin.Configuration.Identity;

namespace Komunumo.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}






