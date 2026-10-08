namespace Panaderia.Models
{
    public class Producto
    {
        public int id { get; set; }

        public string codigo { get; set; } = "";

        public string nombre { get; set; } = "";

        public string categoria { get; set; } = "";

        public string presentacion { get; set; } = "";

        public string tamano { get; set; } = "";

        public string sabor { get; set; } = "";

        public double precio { get; set; }

        public int stock { get; set; }

        public string marca { get; set; } = "";

        public string ingrediente { get; set; } = "";

        public string disponibilidad { get; set; } = "";

        public int descuento { get; set; }

        public string imagen { get; set; } = "";

        public string descripcion { get; set; } = "";
    }
}