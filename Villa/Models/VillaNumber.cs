using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Models
{
    public class VillaNumber
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }
        [ForeignKey("Villas")]
        public int VillaID { get; set; }
        public Villas Villa { get; set; }
        public string SpecialDetails { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}
