using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Tags.In navigation folders.Files")]
	public class Каталог_ФайлТэгаВПапкеНавигации
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Tag")]
		public int ТэгId { get; set; }
		[ForeignKey("ТэгId")]
		public Каталог_ТэгВПапкеНавигации Тэг { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

		[Required]
		[Column("Datas")]
		public byte[] Данные { get; set; }

		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;
	}
}
