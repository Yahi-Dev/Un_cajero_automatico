namespace Tarea1_Leonardo.Models
{
    public class DispensacionModels
    {
        public int TipoDeDispensacion { get; set; }
        public string ModoDispensacion { get; set; }
        public string Nombre { get; set; }
        public List<int> Denominaciones { get; set; }

        public DispensacionModels()
        {

        }
    }
}
