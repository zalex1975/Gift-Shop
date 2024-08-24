namespace SportsStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }                  // ID продукта
        public string Name { get; set; } = string.Empty;    // наименование продукта
        public string Description { get; set; } = "";       //описание
        public decimal Price { get; set; }                  // Стоимость товара
        public string Category { get; set; } = "";          // категория, групировки товаров
        public string Image { get; set; } = "";   // путь для картинки
    }
}
