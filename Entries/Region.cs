using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Regions")]
	public class Region
	{
		[IndexColumn]
		public int Id { get; set; }

		[Required]
		[Column("Name")]
		[MaxLength(100)]
		public string Название { get; set; }

		[Column("Primary phone")]
		public ОсновнойТелефон ОсновнойТелефон { get; set; }

		[InverseProperty("Регион")]
		public List<ГородРегиона> Города { get; set; }
	}

	[Table("Regions: sities")]
	public class ГородРегиона
	{
		public int Id { get; set; }

		[Column("RegionId")]
		public int РегионId { get; set; }
		[ForeignKey("РегионId")]
		public Region Регион { get; set; }

		[Required]
		[Column("Name")]
		[MaxLength(100)]
		public string Название { get; set; }

		[Column("Name in genitive case")]
		[MaxLength(100)]
		public string НазваниеВРодительномПадеже { get; set; }

		[MaxLength(100)]
		public string Subdomain { get; set; }

		[MaxLength(15)]
		[Column("Index")]
		public string Индекс { get; set; }
		[MaxLength(50)]
		[Column("Address")]
		public string Адрес { get; set; }
	}

	public enum ОсновнойТелефон : byte
	{
		Москва = 0,
		Питер = 1, 
		НижнийНовгород = 2,
		Краснодар = 3,
		Воронеж = 4,
		Калуга = 5,
		Казань = 6,
		Екатеринбург = 7,
		Иркутск = 8,
		Ставрополь = 9
	}
}
