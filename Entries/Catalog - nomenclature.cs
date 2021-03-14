using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace AdvisorSTROY.WebSite.Back.DB.Entries
{
	[Table("Catalog.Nomenclaturies")]
	public class Каталог_Номенклатура
	{
		[IndexColumn]
		public int Id { get; set; }

		[IndexColumn]
		[Column("Folder")]
		public int ПапкаId { get; set; }
		[Required]
		[ForeignKey("ПапкаId")]
		public Каталог_Папки Папка { get; set; }

		[Column("Name")]
		[MaxLength(300)]
		[Required]
		public string Название { get; set; }

		[Column("Name for site")]
		[MaxLength(300)]
		public string НазваниеДляСайтов { get; set; }

		[Column("Marketing name")]
		[MaxLength(300)]
		public string МаркетинговоеНазвание { get; set; }

		[Column("CRM name")]
		[MaxLength(300)]
		public string НазваниеДляCRM { get; set; }
		[MaxLength(300)]

		[IndexColumn]
		[Column("WebFile")]
		public string ВебФайл { get; set; }

		[Column("Это услуга")]
		public bool ЭтоУслуга { get; set; } = false;

		[Column("Unit")]
		public Каталог_EдиницаИзмерений ЕдиницаИзмерения { get; set; }
		[Column("Calcs: type")]
		[Required]
		public ТипРасчета ТипРасчета { get; set; } = ТипРасчета.Нет;
		/// <summary>JSON строка с параметрами расчета</summary>
		[Column("Calcs: data")]
		public string ДанныеРасчета { get; set; }

		[IndexColumn]
		[Column("Group")]
		public int? ГруппаId { get; set; }
		[ForeignKey("ГруппаId")]
		public Каталог_ГруппаПапки Группа { get; set; }

		[Column("Annotation")]
		[MaxLength(1000)]
		public string Аннотация { get; set; }
		[Column("Description")]
		public string Описание { get; set; }

		[Column("Trade mark")]
		public int? ТорговаяМаркаId;
		[ForeignKey("ТорговаяМаркаId")]
		public Каталог_ТорговаяМарка ТорговаяМарка { get; set; }

		[MaxLength(300)]
		public string SEO_H1 { get; set; }
		[MaxLength(500)]
		public string SEO_Title { get; set; }		
		[MaxLength(500)]
		public string SEO_Description { get; set; }

		[InverseProperty("Номенклатура")]
		public List<Каталог_ФайлНоменклатуры> Файлы { get; set; } = new List<Каталог_ФайлНоменклатуры>();
		//public List<Каталог_ФотоНоменклатуры> Фотографии { get; set; }

		[InverseProperty("Номенклатура")]
		public List<Каталог_СвязьСвойстваСНоменклатурой> Свойства { get; set; } = new List<Каталог_СвязьСвойстваСНоменклатурой>();

		[Column("Primary photo")]
		public int? ОсновноеФотоId { get; set; }
		[ForeignKey("ОсновноеФотоId")]
		public Каталог_ФотоНоменклатуры ОсновноеФото { get; set; }

		//[ForeignKey("НоменклатураID")]
		//[InverseProperty("НоменклатураID")]
		//public List<Каталог_ФотоНоменклатуры> Фотографии { get; set; }

		[InverseProperty("Номенклатура")]
		public List<Каталог_Товар> Товары { get; set; } = new List<Каталог_Товар>();

		[InverseProperty("Номенклатура")]
		public List<Каталог_СвязьТэгаСНоменклатурой> СвязьСТэгами { get; set; } = new List<Каталог_СвязьТэгаСНоменклатурой>();

		[InverseProperty("Номенклатура")]
		public List<Каталог_ЦенаНоменклатуры> Цены { get; set; } = new List<Каталог_ЦенаНоменклатуры>();
	}

	public enum ТипРасчета : byte
	{
		Нет = 0,
		ПересчетКоличествоИШтукСКоэффициентом = 1
	}

	public class ПараметрыРасчета_ПересчетКоличествоИШтукСКоэффициентом
	{
		public decimal Коэффициент { get; set; } = 0;
	}
}
