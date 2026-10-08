namespace Panaderia.Models
{
    public class DetallePedido
    {
        public int id { get; set; }

        public int pedidoId { get; set; }

        public int productoId { get; set; }

        public int cantidad { get; set; }

        public double precio { get; set; }

        public double subtotal { get; set; }
    }
}