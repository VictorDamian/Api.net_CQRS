using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [Column(TypeName ="VARCHAR(30)")]
    public string Name { get; set; }
    [Required]
    [Column(TypeName ="Decimal(16,2)")]
    public decimal Cost{get;set;}
}
