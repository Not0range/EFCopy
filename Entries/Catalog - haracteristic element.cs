using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Characteristics.Elements")]
	public class Каталог_ЭлементыХарактеристик
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Charact")]
		public int Каталог_ХарактеристикиId { get; set; }
		[ForeignKey("Каталог_ХарактеристикиId")]
		public Каталог_Характеристика Характеристика { get; set; }

		[MaxLength(500)]
		[Required]
		[Column("Value")]
		public string Значение { get; set; }

		[Column("Props")]
		public ДополнительныеДанныеЗначенияХарактеристики[] Свойства { get; set; }
	}

	public class ДополнительныеДанныеЗначенияХарактеристики
	{
		public string sysName { get; set; }
		public string value { get; set; }
	}
}
