using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base
{
    public class BaseEntity
    {

		//[ConfigurationKeyName("MinhaPrimaryKey")]
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public long Id { get; set; }
    }
}
