using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Tags.In navigation folders")]
	public class Каталог_ТэгВПапкеНавигации
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder")]
		public int ПапкаНавигацииID { get; set; }

		[Column("Name")]
		[Required]
		[MaxLength(300)]
		public string Название { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

		[IndexColumn]
		[Column("Tag")]
		public int ТэгID { get; set; }
		[ForeignKey("ТэгID")]
		public Каталог_Тэг Тэг { get; set; }

		[Column("SEO: H1")]
		[MaxLength(500)]
		public string SEO_H1 { get; set; }
		[Column("SEO: Title")]
		[MaxLength(500)]
		public string SEO_Title { get; set; }
		[Column("SEO: Description")]
		[MaxLength(500)]
		public string SEO_Description { get; set; }
		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;

		[Column("Text: source")]
		[Required]
		public string ИсходныйТекст { get; set; }
		[Column("Text")]
		[Required]
		public string КомпилированныйТекст { get; set; }
	}
}
