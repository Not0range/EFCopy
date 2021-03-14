using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Storages")]
	public class Каталог_Склад
	{
		[IndexColumn]
		public int Id { get; set; }

		[Required]
		[MaxLength(200)]
		[Column("Internal name")]
		public string ВнутреннееНазвание { get; set; }

		[Required]
		[MaxLength(200)]
		[Column("Name")]
		public string Название { get; set; }

		[Column("Address")]
		[MaxLength(1000)]
		public string Адрес { get; set; }

		[Column("Transport schema PDF")]
		public byte[]? СхемаПроездаPDF { get; set; }

		[Column("Transport schema PNG")]
		public byte[]? СхемаПроездаPNG { get; set; }
	}
}
