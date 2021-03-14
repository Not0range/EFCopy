using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Articles")]
	public class Article
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder")]
		public int ПапкаНавигацииId { get; set; }
		[ForeignKey("ПапкаНавигацииId")]
		public ПапкаНавигации ПапкаНавигации { get; set; }

		[Required]
		[MaxLength(300)]
		[Column("Name")]
		public string Название { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		[Column("WebFile")]
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

		[Column("Type")]
		public ТипСтатьи Тип { get; set; }

		[InverseProperty("Статья")]
		public List<ФайлыСтатьи> Файлы { get; set; }
	}

	public enum ТипСтатьи : byte
	{
		Статья = 0,

		[Display(Name = "Часто Задаваемые Вопросы")]
		FAQ = 1,

		Тэг = 2
	}
}
