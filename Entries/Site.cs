using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Sites")]
	public class Site
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Required]
		[StringLength(100)]
		[Column("Domain")]
		public string Домен { get; set; }
				
		[Column("Alt domains")]
		[Required]
		public string АльтернативныеДоменыСтрокой { get; set; }

		[NotMapped]
		public HashSet<string> АльтернативныеДомены { get { return (_альтернативныеДоменыКэш == null ? _альтернативныеДоменыКэш  = АльтернативныеДоменыСтрокой.Split('|', StringSplitOptions.RemoveEmptyEntries).ToHashSet<string>(): _альтернативныеДоменыКэш); }
			set { _альтернативныеДоменыКэш = value; АльтернативныеДоменыСтрокой = string.Join('|', _альтернативныеДоменыКэш); }
		}
		[NotMapped]
		private HashSet<string> _альтернативныеДоменыКэш = null;

		[Column("Use SSL")]
		[Required]
		public bool ПоддерживатьSSL { get; set; }

		[StringLength(100)]
		public string Watermark { get; set; }

		[Column("Root folder")]
		public int КорневаяПапкаId { get; set; }

		[Column("Template folder")]
		[Required]
		[StringLength(100)]		
		public string ПапкаШаблона { get; set; }

		[Required]
		[StringLength(100)]
		public string Namespace { get; set; } = "";

		[Column("reCaptcha: Client")]
		public string reCaptcha_Клиент { get; set; }

		[Column("reCaptcha: Server")]
		public string reCaptcha_Сервер { get; set; }

		[Required]
		[Column("User regions")]
		public bool ИспользоватьРегиональность { get; set; } = false;
	}
}
