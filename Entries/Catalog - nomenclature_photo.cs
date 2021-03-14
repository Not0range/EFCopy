using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Photos")]
	public class Каталог_ФотоНоменклатуры
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

		[Column("Name")]
		[MaxLength(300)]
		public string Название { get; set; }

		[Required]
		[Column("Source data")]
		public byte[] ИсходныеДанные { get; set; }

		[Required]
		[Column("Preview")]
		public byte[] Предпросмотр { get; set; }

		[IndexColumn]
		[Column("Preview: WebFile")]
		public string ПредпросмотрWebFile { get; set; }

		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;

		[InverseProperty("ФотографияНоменклатуры")]
		public List<Каталог_CвязьТовараИФото> Товары { get; set; }

		// TODO: Оставлено для совместимости при переносе. Нужно удалить в будущем
		public int? ТоварID { get; set; }
		[ForeignKey("ТоварID")]
		public Каталог_Товар Товар { get; set; }

	}
}
