using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("SpecFiles")]
	public class Specfile
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("SiteId")]
		public int СайтId { get; set; }

		[IndexColumn]
		[Required]
		[MaxLength(300)]
		public string WebFile { get; set; }

		[Column("Data")]
		public byte[] Данные { get; set; }
	}
}
