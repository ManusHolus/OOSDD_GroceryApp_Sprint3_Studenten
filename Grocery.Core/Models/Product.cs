namespace Grocery.Core.Models
{
    public class Product : Model
    {
        public int Stock { get; set; }
        public string Image { get; set; }

        public Product(int id, string name, int stock, string image = null) : base(id, name)
        {
            Stock = stock;
            Image = image;
        }
    }
}
