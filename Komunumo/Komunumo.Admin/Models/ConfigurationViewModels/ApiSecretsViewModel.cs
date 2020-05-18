using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Komunumo.Admin.Models.CommonViewModels;

namespace Komunumo.Admin.Models.ConfigurationViewModels
{
    public class ApiSecretsViewModel
    {
        public ApiSecretsViewModel()
        {
            ApiSecrets = new List<ApiSecretViewModel>();
        }

        public int ApiResourceId { get; set; }

        public int ApiSecretId { get; set; }

        public string ApiResourceName { get; set; }

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

        public List<ApiSecretViewModel> ApiSecrets { get; set; }
    }
}