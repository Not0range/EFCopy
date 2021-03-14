using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Links tovars to provider")]
	public class Каталог_СвязьТовараСПоставщиком
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Tovar")]
		public int ТоварId { get; set; }
		[ForeignKey("ТоварId")]
		[Required]
		public Каталог_Товар Товар { get; set; }

		[IndexColumn]
		[Column("Provider")]
		public Поставщик Поставщик { get; set; }

		[IndexColumn]
		[Column("GUID at provider")]
		public Guid? GUIDУПоставщика { get; set; }
	}

	public enum Поставщик:short
	{
		GrandLine = 1,
		МеталлПрофиль = 2
	}
}
