using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{ 
			ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
			context.Database.Migrate();

			if (!context.Products.Any())
			{
				context.Products.AddRange(
					new Product { ProductId = 0, Name = "Кросовки", Price = 2700, Description = "Крутые кросы", Category = "Обувь" },
					new Product { ProductId = 1, Name = "Кеды", Price = 3200, Description = "Самые крутые кеды", Category = "Обувь" },
					new Product { ProductId = 2, Name = "Кросовки2", Price = 2700, Description = "Крутые кросы", Category = "Обувь" },
					new Product { ProductId = 3, Name = "Кеды2", Price = 3200, Description = "Самые крутые кеды", Category = "Обувь" },
					new Product { ProductId = 4, Name = "Кросовки3", Price = 2700, Description = "Крутые кросы", Category = "Обувь" },
					new Product { ProductId = 5, Name = "Кеды3", Price = 3200, Description = "Самые крутые кеды", Category = "Обувь" },
					new Product { ProductId = 6, Name = "Кросовки4", Price = 2700, Description = "Крутые кросы", Category = "Обувь" },
					new Product { ProductId = 7, Name = "Кеды4", Price = 3200, Description = "Самые крутые кеды", Category = "Обувь" },
					new Product { ProductId = 8, Name = "Футбольный мяч", Price = 1200, Description = "не дорогой мячик", Category = "Спорт инвентарь" },
					new Product { ProductId = 9, Name = "Футбольный мяч от Рональдо", Price = 8700, Description = "Мяч с личной подписью Рональдо", Category = "Спорт инвентарь" },
					new Product { ProductId = 10, Name = "Беговые кроссовки", Price = 3200, Description = "Легкие и удобные кроссовки для бега", Category = "Обувь" },
					new Product { ProductId = 11, Name = "Велосипед", Price = 15000, Description = "Горный велосипед с амортизацией", Category = "Велоспорт" },
					new Product { ProductId = 12, Name = "Гантели", Price = 800, Description = "Набор гантелей разных весов для тренировок", Category = "Фитнес" },
					new Product { ProductId = 13, Name = "Боксерские перчатки", Price = 2500, Description = "Профессиональные перчатки для бокса", Category = "Бокс" },
					new Product { ProductId = 14, Name = "Теннисные мячи", Price = 600, Description = "Набор мячей для тенниса с отличным отскоком", Category = "Теннис" },
					new Product { ProductId = 15, Name = "Спортивный костюм", Price = 3500, Description = "Удобный комплект для занятий спортом", Category = "Одежда" },
					new Product { ProductId = 16, Name = "Ласты для плавания", Price = 1200, Description = "Профессиональные ласты для тренировок в бассейне", Category = "Плавание" },
					new Product { ProductId = 17, Name = "Баскетбольный мяч", Price = 1000, Description = "Официальный мяч для игры в баскетбол", Category = "Баскетбол" },
					new Product { ProductId = 18, Name = "Скакалка", Price = 300, Description = "Легкая скакалка для кардиотренировок", Category = "Фитнес" },
					new Product { ProductId = 19, Name = "Роликовые коньки", Price = 2500, Description = "Удобные ролики для активного катания", Category = "Ролики" },
					new Product { ProductId = 20, Name = "Футбольный мяч", Price = 1500, Description = "Качественный мяч для футбольных игр", Category = "Футбол" },
					new Product { ProductId = 21, Name = "Метательный диск", Price = 800, Description = "Диск для метания в легкой атлетике", Category = "Атлетика" },
					new Product { ProductId = 22, Name = "Беговая дорожка", Price = 12000, Description = "Электрическая беговая дорожка для домашних тренировок", Category = "Фитнес" }
					);


			}
			context.SaveChanges();
		}
	}
}
