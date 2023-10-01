using System.ComponentModel.DataAnnotations;

namespace Villa.Models.DTO
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get;set; }
        public string SpecialDetails { get; set; }
    }
}
