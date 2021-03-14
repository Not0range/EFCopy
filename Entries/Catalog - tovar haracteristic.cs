using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Tovars.Characteristics")]
	public class Каталог_ХарактеристикаТовара
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Tovar")]
		public int ТоварId { get; set; }
		[ForeignKey("ТоварId")]
		public Каталог_Товар Товар { get; set; }

		[IndexColumn]
		[Column("Characteristic")]
		public int? ХарактеристикаId { get; set; }
		[ForeignKey("ХарактеристикаId")]
		public Каталог_Характеристика Характеристика { get; set; }

		[Column("Value")]
		public int ЗначениеId { get; set; }
		[ForeignKey("ЗначениеId")]
		public Каталог_ЭлементыХарактеристик Значение { get; set; }
	}
}
