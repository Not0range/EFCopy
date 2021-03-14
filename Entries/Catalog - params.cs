using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Properties")]
	public class Каталог_Свойство
	{
		[IndexColumn]
		public int Id { get; set; }

		[Column("Internal name")]
		public string ВнутреннееНазвание { get; set; }
		[Column("Name")]
		public string Название { get; set; }

		[InverseProperty("Свойство")]
		public List<Каталог_ЗначениеСвойства> Значения { get; set; }
	}

	[Table("Catalog.Properties.Values")]
	public class Каталог_ЗначениеСвойства
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Property")]
		public int СвойствоId { get; set; }
		[ForeignKey("СвойствоId")]
		public Каталог_Свойство Свойство { get; set; }

		[Column("Value")]
		public string Значение { get; set; }

		[Column("WebFile")]
		public string ВебФайл { get; set; }
	}

	[Table("Catalog.Properties.Values link to Nomenclature")]
	public class Каталог_СвязьСвойстваСНоменклатурой
	{
		[IndexColumn]
		[Column("NomId")]
		public int НоменклатураId { get; set; }
		[ForeignKey("НоменклатураId")]
		public Каталог_Номенклатура Номенклатура { get; set; }

		[IndexColumn]
		[Column("PropValue")]
		public int ЗначениеId { get; set; }
		[ForeignKey("ЗначениеId")]
		public Каталог_ЗначениеСвойства Значение { get; set; }
	}

	[Table("Catalog.Properties.Values link to Tovar")]
	public class Каталог_СвязьСвойстваСТоваром
	{
		[IndexColumn]
		[Column("TovarId")]
		public int ТоварId { get; set; }
		[ForeignKey("ТоварId")]
		public Каталог_Товар Товар { get; set; }

		[IndexColumn]
		[Column("PropValue")]
		public int ЗначениеId { get; set; }
		[ForeignKey("ЗначениеId")]
		public Каталог_ЗначениеСвойства Значение { get; set; }
	}
}
