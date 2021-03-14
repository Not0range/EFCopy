using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Characteristics")]
	public class Каталог_Характеристика
	{
		[IndexColumn]
		public int Id { get; set; }

		[Column("Name")]
		[MaxLength(50)]
		[Required]
		public string Название { get; set; }

		[Column("Props")]
		public string Свойства { get; set; }

		[Column("Type")]
		public ТипХарактеристики Тип { get; set; } = ТипХарактеристики.Обычная;

		[InverseProperty("Характеристика")]
		public List<Каталог_ЭлементыХарактеристик> Значения { get; set; }
	}

	public enum ТипХарактеристики : byte
	{
		Обычная = 0,
		Цены = 1
	}
}
