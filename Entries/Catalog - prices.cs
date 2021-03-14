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
	[Table("Catalog.Prices.Tovars")]
	public class Каталог_ЦенаТовара
	{
		[IndexColumn]
		public long Id { get; set; }

		[IndexColumn]
		[Column("Tovar")]
		public int ТоварId { get; set; }
		[ForeignKey("ТоварId")]
		[Required]
		public Каталог_Товар Товар { get; set; }

		[IndexColumn]
		[Column("Storage")]
		public int? СкладId { get; set; }
		[ForeignKey("СкладId")]
		public Каталог_Склад Склад { get; set; }

		[Column("Price")]
		public decimal? Цена { get; set; }

		[Column("Price retail")]
		public decimal? ЦенаРозницы { get; set; }

		[Column("Availability")]
		public bool? Наличие { get; set; }
	}

	[Table("Catalog.Prices.Nomenclaturies")]
	public class Каталог_ЦенаНоменклатуры
	{
		[IndexColumn]
		public long Id { get; set; }

		[IndexColumn]
		[Column("Nomenclature")]
		public int НоменклатураId { get; set; }
		[ForeignKey("НоменклатураId")]
		[Required]
		public Каталог_Номенклатура Номенклатура { get; set; }

		[IndexColumn]
		[Column("Storage")]
		public int? СкладID { get; set; }
		[ForeignKey("СклaдId")]
		public Каталог_Склад Склад { get; set; }

		[Column("Price from")]
		public decimal? ЦенаОт { get; set; }
		[Column("Price till")]
		public decimal? ЦенаДо { get; set; }

		[Column("Price retail")]
		public decimal? ЦенаРозницы { get; set; }

		[Column("Availability")]
		public bool? Наличие { get; set; }
	}
}
