using Tarea1_Leonardo.Models;

namespace Tarea1_Leonardo.Repositories
{
    public sealed class ModoDispensacionSingleton
    {
        private ModoDispensacionSingleton() { }
        //public ListDispensacionModelAndListPapeletas dispensacion { get; set; }
        public int ModoDispensacion { get; set; }
        public string modoDispensacion {  get; set; }
        public static ModoDispensacionSingleton Instance { get; } = new();
    }
}
