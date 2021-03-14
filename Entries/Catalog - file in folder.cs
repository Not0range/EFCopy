using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Site.Folders params.Files")]
	public class Каталог_ФайлПараметровПапки
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder params")]
		public int ПараметрыПапкиId { get; set; }
		[ForeignKey("ПараметрыПапкиId")]
		public Каталог_ПараметрыПапки ПараметрыПапки { get; set; }

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
