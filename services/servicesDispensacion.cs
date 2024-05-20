using Tarea1_Leonardo.Enums;
using Tarea1_Leonardo.Repositories;
using Tarea1_Leonardo.Enums;
using Tarea1_Leonardo.Models;
using System.Reflection;

namespace Tarea1_Leonardo.services
{
    public class servicesDispensacion
    {
        private readonly ModoDispensacionSingleton _singleton;

        public servicesDispensacion( ModoDispensacionSingleton modoDispensacion)
        {
            _singleton = modoDispensacion;
        }

        public void Add(DispensacionModels model)
         {
            string modoDeDispensacion;
            switch (model.TipoDeDispensacion)
            {
                case (int)ModeType.EFICIENTE:
                   _singleton.ModoDispensacion = 1;
                    break;

                case (int)ModeType.DOCIENTOYMIL:
                    _singleton.ModoDispensacion = 2;
                    break;

                case (int)ModeType.CIENYQUINIENTO:
                    _singleton.ModoDispensacion = 3;
                    break;
            }
         }

        public string GetModoDispensacion()
        {
            switch(_singleton.ModoDispensacion)
            {
                case 1:
                    return AsignarTipo("Dispensacion Eficiente");
                case 2:
                    return AsignarTipo("Retirar de 200 y 1000");
                case 3:
                    return AsignarTipo("Retirar de 100 y 500");

                default: return AsignarTipo("Dispensacion Eficiente");
            }
        }
        public string AsignarTipo(string option)
        {
             return ModoDispensacionSingleton.Instance.modoDispensacion = option;
        }

        //public ListDispensacionModelAndListPapeletas GetInfo()
        //{
        //    return ModoDispensacionSingleton
        //}
    }
}
