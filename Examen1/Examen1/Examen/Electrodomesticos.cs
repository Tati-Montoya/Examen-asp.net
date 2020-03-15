using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Examen
{
    public class Electrodomesticos
    {
        #region Atributos/Propiedades
        //Propiedades de entrada
        public double ValorProducto { get; set; }
        public string EntregaProducto { get; set; }
        private double PorcentajeIva;
        //Propiedades de salida
        public double ValorSinDescuento { get; private set; }
        public double ValorDescuento { get; private set; }
        public double ValorTotal { get; private set; }
        public double ValorAntesIva { get; private set; }
        public double ValorIva { get; private set; }
        public string Error { get; private set; }
       
        #endregion

        #region Metodos
        public void CalcularValorTotal()
        {
           if (CalcularValorDescuento())
            {
                ValorTotal = ValorProducto - ValorDescuento;
                CalcularValorSinDescuento();
                CalcularValorAntesIva();
                CalcularValorIva();
            }
            else
            {
                ValorTotal = ValorProducto;
                CalcularValorSinDescuento();
                CalcularValorAntesIva();
                CalcularValorIva();
            }

        }
        private void CalcularValorAntesIva()
        {
            PorcentajeIva = 0.19;

            ValorAntesIva = ValorTotal / (1 + PorcentajeIva); 
        }
        private bool CalcularValorDescuento ()
        {
            if (EntregaProducto == "SI")
            {
                ValorDescuento = (ValorProducto / 100) * 30;
                return true;
            }
            return false;
        }
        private void CalcularValorIva()
        {
            ValorIva = ValorTotal - ValorAntesIva;
        }
        private void CalcularValorSinDescuento()
        {
           ValorSinDescuento = ValorProducto;
        }
        #endregion
    }
}
