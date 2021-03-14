using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies.Links to navigation folders")]
	public class Каталог_СвязьНоменклатурыСПапкойНавигации
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
		[Required]
		public Каталог_Номенклатура Номенклатура { get; set; }
	}
}
