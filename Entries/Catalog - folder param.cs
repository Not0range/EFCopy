using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Site.Folders params")]
	public class Каталог_ПараметрыПапки
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Nav folder")]
		public int ПапкаId { get; set; }
		[Required]
		[ForeignKey("ПапкаId")]
		public ПапкаНавигации Папка { get; set; }

		[MaxLength(500)]
		public string SEO_H1 { get; set; }

		[MaxLength(500)]
		public string SEO_Title { get; set; }
		[MaxLength(500)]
		public string SEO_Description { get; set; }

		[MaxLength(1000)]
		[Column("Annotation for list")]
		public string АннотацияДляСписка { get; set; }
		[Column("Top text")]
		public string ТекстСверху { get; set; }
		[Column("Bottom text")]
		public string ТекстСнизу { get; set; }

		[Column("Params")]
		public НастройкиПапкиКаталога Настройки { get; set; } = null;

		[Column("Update date")]
		[Required]
		public DateTime ДатаОбновления { get; set; } = DateTime.Now;
	}

	public class НастройкиПапкиКаталога
	{
		public List<ГруппаПапкиКаталога> Группы { get; set; } = new();
	}

	public class ГруппаПапкиКаталога
	{
		public Guid Id { get; set; }
		public string Название { get; set; }
		public string Описание { get; set; }
		public List<ПапкаКаталогаНавигации> Папки { get; set; } = new();
	}

	public class ПапкаКаталогаНавигации
	{
		public int Id { get; set; }
	}
}
