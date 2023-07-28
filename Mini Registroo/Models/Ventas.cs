namespace Mini_Registroo.Models
{
    public class Ventas
    {
        public int Id { get; set; }
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
