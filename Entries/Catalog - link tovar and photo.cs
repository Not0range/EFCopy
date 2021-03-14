using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Tovars.Photos")]
	public class Каталог_CвязьТовараИФото
	{
		[IndexColumn]
		[Column("Tovar")]
		public int ТоварId { get; set; }
		[ForeignKey("ТоварId")]
		public Каталог_Товар Товар { get; set; }

		[IndexColumn]
		[Column("Photo")]
		public int ФотографияНоменклатурыId { get; set; }
		[ForeignKey("ФотографияНоменклатурыId")]
		public Каталог_ФотоНоменклатуры ФотографияНоменклатуры{ get; set; }
	}
}
