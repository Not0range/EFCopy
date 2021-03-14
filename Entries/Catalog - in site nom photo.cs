using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Photos in site")]
	public class Каталог_ФотографияНоменклатурыНаСайте
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder")]
		public int ПапкаНавигацииId { get; set; }
		[ForeignKey("ПапкаНавигацииId")]
		public ПапкаНавигации ПапкаНавигации { get; set; }

		[IndexColumn]
		[Column("Nomenclature")]
		public int НоменклатураId { get; set; }
		[ForeignKey("НоменклатураId")]
		public Каталог_Номенклатура Номенклатура { get; set; }

		[IndexColumn]
		[Column("Original photo")]
		public int ОригиналФотоId { get; set; }
		[ForeignKey("ОригиналФотоId")]
		public Каталог_ФотоНоменклатуры ОригиналФото { get; set; }

		[Column("Preview: micro")]
		public byte[] ПредпросмотрМикро { get; set; }
		[Column("Preview: middle")]
		public byte[] ПредпросмотрСредний { get; set; }
		[Column("Preview: big")]

		public byte[] ПредпросмотрКрупный { get; set; }
		[Column("Preview: full")]
		public byte[] ПредпросмотрПолный { get; set; }

		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;
	}
}
