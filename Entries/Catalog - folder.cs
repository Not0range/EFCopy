using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Folders")]
	public class Каталог_Папки
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Parent")]
		public int? Родитель { get; set; }

		[Required]
		[Column("Name")]
		[MaxLength(100)]
		public string Название { get; set; }

		[InverseProperty("Папка")]
		public List<Каталог_ГруппаПапки> Группы { get; set; }

		[InverseProperty("ПапкаКаталога")]
		public List<Каталог_СвязьПапкиНоменклатурыСПапкойНавигации> СвязьСНавигацией { get; set; }
	}
}
