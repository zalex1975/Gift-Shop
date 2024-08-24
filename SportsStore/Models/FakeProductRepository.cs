namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product { ProductId = 1, Name = "ЧУМ", Price = 700, Description = "Магнит со смолой и надписью Сургут", Category = "Магниты сувенирные", Image = @"\Image\Magnets\i.webp" },
            new Product { ProductId = 2, Name = "ХРАМ", Price = 600, Description = "Магнит с изображением храма (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\d.webp" },
            new Product { ProductId = 3, Name = "ПАМЯТНИК ОСНОВАТЕЛЯМ", Price = 720, Description = "Магнит с изображением  памятника основателям (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\t.webp" },
            new Product { ProductId = 4, Name = "ЧЕМОДАН", Price = 550, Description = "Магнит в форме чемодана с изображением достопримечательностей (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\h.webp" },
            new Product { ProductId = 5, Name = "ШАМАН", Price = 800, Description = "Магнит в форме шамана (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\l.webp" },
            new Product { ProductId = 6, Name = "ТЕРМОМЕТР", Price = 680, Description = "Магнит многослойный с термометром на фоне месторождений и памятника основателям (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\k.webp" },
            new Product { ProductId = 7, Name = "МАМОНТ", Price = 568, Description = "Магнит в форме мамонта (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\u.webp" },
            new Product { ProductId = 8, Name = "ГЕРБ", Price = 850, Description = "Магнит с изображением Герба (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\y.webp" },
            new Product { ProductId = 9, Name = "КОЛОКОЛЬЧИК", Price = 700, Description = "Магнит раздвижной в форме колокольчика с изображением храма (Сургут)", Category = "Магниты сувенирные", Image = @"\Image\Magnets\w.webp" },
            new Product { ProductId = 10, Name = "ТАРЕЛКА СУВЕНИРНАЯ", Price = 1200, Description = "Тарелка сувенирная с изображением достопримечательностей (Сургут)", Category = "Тарелки сувенирные", Image = @"\Image\Plate\d.webp" },
            new Product { ProductId = 11, Name = "ТАРЕЛКА СУВЕНИРНАЯ", Price = 900, Description = "Тарелка сувенирная с изображением достопримечательностей (Сургут)", Category = "Тарелки сувенирные", Image = @"\Image\Plate\f.webp" },
            new Product { ProductId = 12, Name = "ТАРЕЛКА СУВЕНИРНАЯ", Price = 1100, Description = "Тарелка сувенирная с изображением нефтеного месторождения (Сургут)", Category = "Тарелки сувенирные", Image = @"\Image\Plate\i.webp" },
            new Product { ProductId = 13, Name = "ТАРЕЛКА СУВЕНИРНАЯ", Price = 1500, Description = "Тарелка сувенирная с изображением моста через р.Обь (Сургут)", Category = "Тарелки сувенирные", Image = @"\Image\Plate\r.webp" },
            new Product { ProductId = 14, Name = "ТАРЕЛКА СУВЕНИРНАЯ", Price = 850, Description = "Тарелка сувенирная с изображением достопримечательностей (Сургут)", Category = "Тарелки сувенирные", Image = @"\Image\Plate\h.webp" },
            new Product { ProductId = 15, Name = "КОЛОКОЛЬЧИК", Price = 570, Description = "Статуэтка колокольчик со вставкой (Сургут)", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\t.webp" },
            new Product { ProductId = 16, Name = "ЧЁРНЫЙ ЛИС", Price = 1000, Description = "Статуэтка черный лис - гипс (Сургут)", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\d.webp" },
            new Product { ProductId = 17, Name = "КОЛОКОЛЬЧИК", Price = 600, Description = "Статуэтка колокольчик в форме капли (Сургут)", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\g.webp" },
            new Product { ProductId = 18, Name = "МЕДВЕДИ", Price = 950, Description = "Статуэтки из гипса", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\m.webp" },
            new Product { ProductId = 19, Name = "ЧЁРНЫЙ ЛИС", Price = 1600, Description = "Статуэтка черный лис - латунь (Сургут)", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\x.webp" },
            new Product { ProductId = 20, Name = "КОЛОКОЛЬЧИК", Price = 750, Description = "Статуэтка колокольчик в форме чума (Сургут)", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\a.webp" },
            new Product { ProductId = 21, Name = "ВЫШКА-КАЧАЛКА", Price = 2100, Description = "Статуэтка нефтяная вышка-качалка (Сургут)", Category = "Статуэтки сувенирные", Image = @"\Image\Figurines\i.webp" },
            new Product { ProductId = 22, Name = "НАПЁРСТОК", Price = 500, Description = "Напёрсток сувенирный (Сургут), металлический", Category = "Напёрсток сувенирный", Image = @"\Image\Thimble\b.webp" },
            new Product { ProductId = 23, Name = "НАПЁРСТОК", Price = 2000, Description = "Напёрсток сувенирный (Сургут), чернёное серебро", Category = "Напёрсток сувенирный", Image = @"\Image\Thimble\i.webp" },
            new Product { ProductId = 24, Name = "НАПЁРСТОК", Price = 900, Description = "Напёрсток сувенирный (Сургут), латунь", Category = "Напёрсток сувенирный", Image = @"\Image\Thimble\s.webp" },
            new Product { ProductId = 25, Name = "КРУЖКА", Price = 520, Description = "Кружка сувенирная (Сургут)", Category = "Кружка сувенирная", Image = @"\Image\Glasses\k.webp" },
            new Product { ProductId = 26, Name = "КРУЖКА", Price = 520, Description = "Кружка сувенирная (Сургут)", Category = "Кружка сувенирная", Image = @"\Image\Glasses\j.webp" },
            new Product { ProductId = 27, Name = "КРУЖКА", Price = 700, Description = "Кружка сувенирная (Сургут)", Category = "Кружка сувенирная", Image = @"\Image\Glasses\g.webp" },
            new Product { ProductId = 28, Name = "БОКАЛЫ", Price = 1500, Description = "Бокалы сувенирные (Сургут)", Category = "Кружка сувенирная", Image = @"\Image\Glasses\w.webp" },
            new Product { ProductId = 29, Name = "РЮМКА", Price = 250, Description = "Рюмка сувенирная (Сургут)", Category = "Кружка сувенирная", Image = @"\Image\Glasses\r.webp" }
        }.AsQueryable<Product>();
    }
}
