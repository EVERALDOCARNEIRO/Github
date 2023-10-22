using GeekShopping.ProductAPI.Model.Base;
using Microsoft.AspNetCore.Razor.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{

	[Table("Product")]
	public class Product : BaseEntity
	{
		[Column("Nome")]
		[Required]
		[StringLength(150)]
		public string Name { get; set; } = string.Empty;

		[Column("Price")]
		[Required]
		[Range(0,1000000000)]
		public decimal Price { get; set; }

		[Column("Descricao")]
		[Required]
		[StringLength(500)]
		public string Descricao {  get; set; } = string.Empty;

		[Column("Categoria")]
		[Required]
		[StringLength(50)]
		public string Categoria { get; set; } = string.Empty;

		[Column("ImageURL")]
		[Required]
		[StringLength(250)]
		public string ImageURL { get; set; } = string.Empty;

	}
}
