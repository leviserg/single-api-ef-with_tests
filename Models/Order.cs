using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace single_api.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(100)")]
        [MaxLength(100)]
        public required string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime LastChanged { get; set; }
    }
}
