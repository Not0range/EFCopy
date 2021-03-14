using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Files")]
	public class Каталог_ФайлНоменклатуры
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Nomenclature")]
		public int НоменклатураId { get; set; }

		[ForeignKey("НоменклатураId")]
		public Каталог_Номенклатура Номенклатура { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

		[Required]
		[Column("Data")]
		public byte[] Данные { get; set; }

		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;
	}
}