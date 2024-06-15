namespace POS.Data.Entities
{
    public class TipoProducto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; }

        public TipoProducto()
        {
            Descripcion = string.Empty;
            Productos = [];
        }
    }
}
