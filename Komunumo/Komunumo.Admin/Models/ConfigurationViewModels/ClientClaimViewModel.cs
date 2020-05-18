using System.ComponentModel.DataAnnotations;

namespace Komunumo.Admin.Models.ConfigurationViewModels
{
    public class ClientClaimViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Value { get; set; }
    }
}