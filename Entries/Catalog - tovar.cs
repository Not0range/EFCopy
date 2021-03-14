using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Tovars")]
	public class Каталог_Товар
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Nomenclature")]
		public int НоменклатураId { get; set; }
		[ForeignKey("НоменклатураId")]
		[Required]
		public Каталог_Номенклатура Номенклатура { get; set; }

		[Column("Add to name")]
		[MaxLength(100)]
		public string ДополнениеКНазванию { get; set; }

		[Required]
		[Column("Status")]
		public СтатусТовара Статус { get; set; } = СтатусТовара.Включен;

		[Column("Primary photo")]
		public int? ОсновнаяФотографияId { get; set; }
		[ForeignKey("ОсновнаяФотографияId")]
		public Каталог_ФотоНоменклатуры ОсновнаяФотография { get; set; }

		[InverseProperty("Товар")]
		public List<Каталог_ХарактеристикаТовара> Характеристики { get; set; } = new List<Каталог_ХарактеристикаТовара>();

		[InverseProperty("Товар")]
		public List<Каталог_СвязьТовараСПоставщиком> СвязьСПоставщиком { get; set; }

		[InverseProperty("Товар")]
		public List<Каталог_ЦенаТовара> Цены { get; set; }

		[InverseProperty("Товар")]
		public List<Каталог_СвязьСвойстваСТоваром> Свойства { get; set; }
	}

	public enum СтатусТовара : byte
	{
		Выключен = 0,
		Включен = 1
	}
}
