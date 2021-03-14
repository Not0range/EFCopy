using AdvisorSTROY.WebSite.Back.DB.Entries;

using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Toolbelt.ComponentModel.DataAnnotations;

namespace AdvisorSTROY.WebSite.Back.DB.Context
{
	public class КонтекстСайтаБД : DbContext
	{
		public КонтекстСайтаБД(DbContextOptions<КонтекстСайтаБД> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=ORANGEVM-PC\SQLEXPRESS;" +
            "Initial Catalog=Blog;Trusted_Connection=True;");

		public DbSet<Administrator> Администраторы { get; set; }

		public DbSet<Site> Сайты { get; set; }
		public DbSet<ПапкаНавигации> ПапкиНавигации { get; set; }
		//public DbSet<РегионыПодсайтов> РегионыПодсайтов { get; set; }
		public DbSet<Region> Регионы { get; set; }
		public DbSet<ГородРегиона> ГородаРегионов { get; set; }
		public DbSet<Article> Статьи { get; set; }
		public DbSet<ФайлыСтатьи> ФайлыСтатей { get; set; }
		public DbSet<Новость> Новости { get; set; }
		public DbSet<ФайлНовости> ФайлыНовостей { get; set; }

		public DbSet<User> Пользователи { get; set; }

		public DbSet<Specfile> Спецфайлы { get; set; }

		public DbSet<Каталог_Папки> Каталог_Папки { get; set; }
		public DbSet<Каталог_ГруппаПапки> Каталог_Группы { get; set; }
		public DbSet<Каталог_EдиницаИзмерений> Каталог_EдиницыИзмерения { get; set; }
		public DbSet<Каталог_Характеристика> Каталог_Характеристики { get; set; }
		public DbSet<Каталог_ЭлементыХарактеристик> Каталог_ЭлементыХарактеристикs { get; set; }
		public DbSet<Каталог_ТорговаяМарка> Каталог_ТорговыеМарки { get; set; }
		public DbSet<Каталог_ПараметрыПапки> Каталог_ПараметрыПапки { get; set; }
		public DbSet<Каталог_ФайлПараметровПапки> Каталог_ФайлыПараметровПапки { get; set; }
		public DbSet<Каталог_Номенклатура> Каталог_Номенклатура { get; set; }
		public DbSet<Каталог_Товар> Каталог_Товары { get; set; }
		public DbSet<Каталог_ЦенаТовара> Каталог_ЦеныТовара { get; set; }
		public DbSet<Каталог_ЦенаНоменклатуры> Каталог_ЦеныНоменклатуры { get; set; }

		public DbSet<Каталог_CвязьТовараИФото> Каталог_CвязьТоваровИФото { get; set; }
		public DbSet<Каталог_Склад> Каталог_Склады { get; set; }
		public DbSet<Каталог_ФайлНоменклатуры> Каталог_ФайлыНоменклатуры { get; set; }
		public DbSet<Каталог_ФотоНоменклатуры> Каталог_ФотоНоменклатуры { get; set; }
		public DbSet<Каталог_СвязьНоменклатурыСПапкойНавигации> Каталог_СвязьНоменклатурСПапкамиНавигации { get; set; }
		public DbSet<Каталог_СвязьПапкиНоменклатурыСПапкойНавигации> Каталог_СвязьПапокНоменклатурыСПапкойНавигации { get; set; }
		public DbSet<Каталог_ФотографияНоменклатурыНаСайте> Каталог_ФотографииНоменклатурыНаСайте { get; set; }

		public DbSet<Каталог_ХарактеристикаТовара> Каталог_ХаракктеристикиТоваров { get; set; }
		public DbSet<Каталог_Тэг> Каталог_Тэги { get; set; }
		public DbSet<Каталог_СвязьТэгаСНоменклатурой> Каталог_СвязьТэговСНоменклатурой { get; set; }

		public DbSet<Каталог_ТэгВПапкеНавигации> Каталог_ТэгиВПапкеНавигации { get; set; }
		public DbSet<Каталог_ФайлТэгаВПапкеНавигации> Каталог_ФайлыТэгаВПапкеНавигации { get; set; }
		public DbSet<Каталог_СвязьТовараСПоставщиком> Каталог_СвязьТоваровСПоставщиком { get; set; }

		public DbSet<Каталог_Свойство> Каталог_Свойства { get; set; }
		public DbSet<Каталог_ЗначениеСвойства> Каталог_ЗначенияСвойств { get; set; }
		public DbSet<Каталог_СвязьСвойстваСНоменклатурой> Каталог_СвязьСвойствСНоменклатурой { get; set; }
		public DbSet<Каталог_СвязьСвойстваСТоваром> Каталог_СвязьСвойствСТоварами { get; set; }

		public DbSet<Banner> Баннеры { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.BuildIndexesFromAnnotations();

			modelBuilder.Entity<Каталог_Номенклатура>()
	.HasOne(b => b.ОсновноеФото)
	.WithOne(z => z.Номенклатура)
	.IsRequired(false)
	.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Каталог_ЭлементыХарактеристик>().Property(z => z.Свойства).HasConversion(
				v => JsonConvert.SerializeObject(v),
				v => JsonConvert.DeserializeObject<ДополнительныеДанныеЗначенияХарактеристики[]>(v)
			);

			modelBuilder.Entity<Каталог_CвязьТовараИФото>().HasKey(b => new { b.ТоварId, b.ФотографияНоменклатурыId });
			//modelBuilder.Entity<Каталог_СвязьТэгаСНоменклатурой>().HasNoKey();			

			modelBuilder.Entity<Каталог_СвязьТэгаСНоменклатурой>().HasKey(b => new { b.ТэгId, b.НоменклатураId });
			modelBuilder.Entity<Каталог_СвязьТэгаСНоменклатурой>()
				.HasOne(m => m.Тэг)
				.WithMany(m => m.СвязьСНоменклатурой)
				.HasForeignKey(m => m.ТэгId);
			modelBuilder.Entity<Каталог_СвязьТэгаСНоменклатурой>()
				.HasOne(m => m.Номенклатура)
				.WithMany(m => m.СвязьСТэгами)
				.HasForeignKey(m => m.НоменклатураId);


			modelBuilder.Entity<Каталог_Тэг>().Property(z => z.Тип).HasDefaultValue(ТипТэга.Информационный);

			modelBuilder.Entity<Каталог_ПараметрыПапки>().Property(z => z.Настройки).HasConversion(
				v => JsonConvert.SerializeObject(v),
				v => JsonConvert.DeserializeObject<НастройкиПапкиКаталога>(v)
			);

			modelBuilder.Entity<Каталог_СвязьСвойстваСНоменклатурой>().HasKey(b => new { b.НоменклатураId, b.ЗначениеId });
			modelBuilder.Entity<Каталог_СвязьСвойстваСТоваром>().HasKey(b => new { b.ТоварId, b.ЗначениеId });

		}
	}
}
