using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("Nome")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Column("Descricao")]
		[Required]
		[StringLength(500)]
        public string Description { get; set; }

		[Column("PrecoUnitario")]
		[Required]
		[Range(1, 10000)]
		public decimal Price { get; set; }
		
        [Column("Categoria")]
		[Required]
		[StringLength(50)]
        public string CategoryName { get; set; }

		[Required]
		[Column("ImageURL")]
        [StringLength(300)]
        public string ImageURL { get; set; }
    }
}
