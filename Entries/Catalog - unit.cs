using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Units")]
	public class Каталог_EдиницаИзмерений
	{
		[Key]
		[IndexColumn]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Required]
		[Column("Code")]
		public int Код { get; set; }

		[Column("Name")]
		[MaxLength(15)]
		public string Название { get; set; }

		[Column("HTML name")]
		[MaxLength(50)]
		public string НазваниеHTML { get; set; }

		[Column("Price for")]
		[MaxLength(50)]
		public string ЦеназЗа { get; set; }
	}
}
