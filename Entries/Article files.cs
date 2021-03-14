using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Articles.Files")]
	public class ФайлыСтатьи
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Article")]
		public int СтатьяId { get; set; }
		[ForeignKey("СтатьяId")]
		public Article Статья {get;set;}

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

		[Required]
		[Column("Data")]
		public byte[] Данные { get; set; }

		[Column("Publish date")]
		public DateTime ДатаПубликации { get; set; } = DateTime.Now;
	}
}
