namespace tecweb1.Models
{
    public class Producto
    {
        public int Id { get; set; }
         public string Name { get; set; }
        public int Description { get; set; }
        public decimal Price { get; set; }
        public double Amount { get; set;}
     
        public List<Pedido> Pedidos { get; set; }
    }
}
