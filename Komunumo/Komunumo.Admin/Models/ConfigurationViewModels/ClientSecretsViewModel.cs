using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Komunumo.Admin.Models.Common;

namespace Komunumo.Admin.Models.ConfigurationViewModels
{
    public class ClientSecretsViewModel
    {
        public ClientSecretsViewModel()
        {
            ClientSecrets = new List<ClientSecretViewModel>();
        }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public int ClientSecretId { get; set; }

        [Required]
        public string Type { get; set; } = "SharedSecret";

        public List<SelectItemViewModel> TypeList { get; set; }

        public string Description { get; set; }

        [Required]
        public string Value { get; set; }

        public string HashType { get; set; }

        public List<SelectItemViewModel> HashTypes { get; set; }

        public DateTime? Expiration { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public List<ClientSecretViewModel> ClientSecrets { get; set; }
    }
}