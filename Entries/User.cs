using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Security.Users")]
	public class User
	{
		[IndexColumn]
		public int Id { get; set; }

		[Column("Name")]
		[Required]
		public string Имя { get; set; }

		[Column("Birthday")]
		public DateTime? ДатаРождения { get; set; }

		[Column("Last access date")]
		public DateTime? ДатаПоследнегоДоступа { get; set; }

		[IndexColumn]
		[Required]
		public string EMail { get; set; }

		[Column("EMail: confirmed")]
		public bool EMailПодтвержден { get; set; }

		[Column("Status")]
		public Безопасность.СтатусПользователя Статус { get; set; } = Безопасность.СтатусПользователя.Активен;

		[Column("Password")]
		public string Пароль { get; set; }
	}
}
