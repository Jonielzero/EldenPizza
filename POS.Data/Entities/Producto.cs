namespace POS.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoProductoId { get; set; }
        public decimal Precio { get; set; }

        public TipoProducto TipoProducto { get; set; }

        public Producto()
        {
            Nombre = string.Empty;
            TipoProducto = new TipoProducto();
        }
    }
}
