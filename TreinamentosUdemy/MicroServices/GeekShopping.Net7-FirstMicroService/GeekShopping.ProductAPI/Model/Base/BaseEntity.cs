using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base
{
	public class BaseEntity
	{
		[key]
		[Column("id")]
		public long Id { get; set; }
	}
}
