using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("News")]
	public class Новость
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder")]
		public int ПапкаНавигацииId { get; set; }

		[IndexColumn]
		[Required]
		[Column("Date")]
		public DateTime Дата { get; set; }
		[Column("Finish date")]
		public DateTime? ДатаОкончания { get; set; }

		[Column("Name")]
		[Required]
		[MaxLength(300)]
		public string Название { get; set; }

		[Column("Annotation")]
		[Required]
		[MaxLength(500)]
		public string Аннотация { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

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

	[Table("News.Files")]
	public class ФайлНовости
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("NewsId")]
		public int НовостьId { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

		[Column("Data")]
		[Required]
		public byte[] Данные { get; set; }

		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;
	}
}
