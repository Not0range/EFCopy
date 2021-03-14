using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Tags")]
	public class Каталог_Тэг
	{
		[IndexColumn]
		public int Id { get; set; }

		[Column("Name")]
		[MaxLength(100)]
		[Required]
		public string Название { get; set; }

		[Column("Type")]
		[Required]
		public ТипТэга Тип { get; set; } = ТипТэга.Информационный;

		[Column("Value")]
		public string Значение { get; set; }

		[InverseProperty("Тэг")]
		public List<Каталог_СвязьТэгаСНоменклатурой> СвязьСНоменклатурой { get; set; }
	}

	public enum ТипТэга: byte{
		Информационный = 0,
		Ценовой = 1
	}

	[Table("Catalog.Tags.Links with nomenclature")]
	public class Каталог_СвязьТэгаСНоменклатурой
	{
		[IndexColumn]
		[Column("Tag")]
		public int ТэгId { get; set; }
		[ForeignKey("ТэгId")]
		public Каталог_Тэг Тэг { get; set; }

		[IndexColumn]
		[Column("Nomenclature")]
		public int НоменклатураId { get; set; }
		[ForeignKey("НоменклатураId")]
		public Каталог_Номенклатура Номенклатура {get;set;}
	}
}
