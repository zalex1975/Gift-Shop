namespace SportsStore.Models
{
    public class Cart
    {
        private List<CartLine>  cartLines = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            var currentLine = cartLines.Where(x=>x.Product.ProductId == product.ProductId).FirstOrDefault();

            if (currentLine == null)
            {
                cartLines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
                currentLine.Quantity += quantity;
        }
        public virtual void RemoveItem(Product product) => 
            cartLines.RemoveAll(x=>x.Product.ProductId == product.ProductId);
        public virtual decimal ComputeTotalValue() => cartLines.Sum(x => x.Product.Price * x.Quantity);
        public virtual void Clear() => cartLines.Clear();
        public virtual IEnumerable<CartLine> Lines => cartLines;
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
