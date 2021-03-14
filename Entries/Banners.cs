using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Banners")]
	public class Banner
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("SiteId")]
		public int SiteId { get; set; }
		[ForeignKey("СайтId")]
		public Site Site { get; set; }

		[Column("Image")]
		public byte[] Image { get; set; }

		public string Alt { get; set; }

		public string URL { get; set; }

		[Column("Start date")]
		public DateTime BeginDate { get; set; }
		[Column("End date")]
		public DateTime EndDate { get; set; }

		[Column("Is show")]
		public bool IsShow { get; set; }

		[Column("Place name")]
		public string Place { get; set; }
	}
}
