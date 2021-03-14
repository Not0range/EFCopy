using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;
using System.ComponentModel.DataAnnotations;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Folders.Links to navigation folders")]
	public class Каталог_СвязьПапкиНоменклатурыСПапкойНавигации
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Nav folder")]
		public int ПапкаНавигацииId { get; set; }
		[ForeignKey("ПапкаНавигацииId")]
		[Required]
		public ПапкаНавигации ПапкаНавигации { get; set; }

		[IndexColumn]
		[Column("Catalog folder")]
		public int ПапкаКаталогаId { get; set; }
		[ForeignKey("ПапкаКаталогаId")]
		[Required]
		public Каталог_Папки ПапкаКаталога { get; set; }
	}
}
