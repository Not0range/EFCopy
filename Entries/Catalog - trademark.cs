using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{

	[Table("Catalog.TradeMarks")]
	public class Каталог_ТорговаяМарка
	{
		[IndexColumn]
		public int Id { get; set; }

		[Column("Name")]
		[MaxLength(50)]
		[Required]
		public string Название { get; set; }

		[Column("Country of production")]
		[MaxLength(50)]
		public string СтранаПроизводства { get; set; }
	}
}
