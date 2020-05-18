using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Komunumo.Admin.Models.ConfigurationViewModels
{
    public class ClientPropertiesViewModel
    {
        public ClientPropertiesViewModel()
        {
            ClientProperties = new List<ClientPropertyViewModel>();
        }

        public int ClientPropertyId { get; set; }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        [Required]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        public List<ClientPropertyViewModel> ClientProperties { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }
    }
}