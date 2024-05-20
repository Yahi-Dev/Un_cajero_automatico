namespace Tarea1_Leonardo.services
{
    public class ServicesBilletes
    {
        public int[] calculoDispensacion(string modo, int monto)
        {
            int[] cantidadesDenominaciones = new int[4];

            int cantidadEntera = monto;

            switch (modo)
            {
                case "Dispensacion Eficiente":
                    int[] denominacionesEficiente = { 100, 200, 500, 1000 };
                    for (int i = denominacionesEficiente.Length - 1; i >= 0; i--)
                    {
                        int cantidadBilletes = cantidadEntera / denominacionesEficiente[i];
                        cantidadesDenominaciones[i] = cantidadBilletes;
                        cantidadEntera %= denominacionesEficiente[i];
                    }
                    break;

                case "Retirar de 200 y 1000":
                    int[] denominacionesDoscientosMil = { 200, 1000 };
                    for (int i = denominacionesDoscientosMil.Length - 1; i >= 0; i--)
                    {
                        int cantidadBilletes = cantidadEntera / denominacionesDoscientosMil[i];
                        cantidadesDenominaciones[i == 0 ? 1 : 3] = cantidadBilletes; 
                        cantidadEntera %= denominacionesDoscientosMil[i];
                    }
                    break;

                case "Retirar de 100 y 500":
                    int[] denominacionesCienQuinientos = { 100, 500 };
                    for (int i = denominacionesCienQuinientos.Length - 1; i >= 0; i--)
                    {
                        int cantidadBilletes = cantidadEntera / denominacionesCienQuinientos[i];
                        cantidadesDenominaciones[i == 0 ? 0 : 2] = cantidadBilletes; 
                        cantidadEntera %= denominacionesCienQuinientos[i];
                    }
                    break;

                default:
                    break;
            }

            return cantidadesDenominaciones;
        }
    }
}