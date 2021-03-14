using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{

	[Table("Catalog.Folders.Groups")]
	public class Каталог_ГруппаПапки
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder")]
		public int ПапкаId { get; set; }
		[Required]
		[ForeignKey("ПапкаId")]
		public Каталог_Папки Папка { get; set; }

		[Column("Priority")]
		[Required]
		public byte Приоритет {get;set;}

		[Column("Name")]
		[MaxLength(100)]
		[Required]
		public string Название { get; set; }

		[InverseProperty("Группа")]
		public List<Каталог_Номенклатура> Номенклатуры { get; set; }
	}
}
