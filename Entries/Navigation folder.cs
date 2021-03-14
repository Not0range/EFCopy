using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Navigation.Folders")]
	public class ПапкаНавигации
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Parent Id")]
		public int? ПапкаНавигацииId { get; set; }

		[Required]
		[Column("Name")]
		[MaxLength(100)]
		public string Название { get; set; }

		[Column("Breadcrumbs")]
		[MaxLength(100)]
		public string НазваниеBreadcrumbs { get; set; }

		[Required]
		[Column("WebFile")]
		[MaxLength(100)]
		public string ВебФайл { get; set; }

		[Column("Type")]
		public Навигация.ТипПапкиНавигации Тип { get; set; }
	}
}
