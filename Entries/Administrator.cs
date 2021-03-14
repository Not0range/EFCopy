using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Security.Admins")]
	public class Administrator
	{
		[IndexColumn]
		public int Id { get; set; }

		[Required]
		[Column("Account")]
		public string УчетнаяЗапись { get; set; }
		[Column("Password")]
		public string Пароль { get; set; }

		[Column("Access")]
		public string Доступ { get; set; }

		[Column("IsActive")]
		public bool Активен { get; set; }
	}
}
