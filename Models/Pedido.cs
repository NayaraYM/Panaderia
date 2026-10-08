namespace Panaderia.Models
{
    public class Pedido
    {
        public int id { get; set; }

        public int clienteId { get; set; }

        public DateTime fecha { get; set; }

        public double total { get; set; }

        public string estado { get; set; } = "";
    }
}