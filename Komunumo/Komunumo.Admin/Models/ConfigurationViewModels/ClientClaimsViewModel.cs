using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Komunumo.Admin.Models.ConfigurationViewModels
{
    public class ClientClaimsViewModel
    {
        public ClientClaimsViewModel()
        {
            ClientClaims = new List<ClientClaimViewModel>();
        }

        public int ClientClaimId { get; set; }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Value { get; set; }

        public List<ClientClaimViewModel> ClientClaims { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }
    }
}