using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen1.Examen;

namespace WebExamen.examen
{
    public partial class VistaExamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            string EntregaProducto;
            double ValorProducto;

            EntregaProducto = dpdEntregaProdcuto.Text;
            ValorProducto = Convert.ToDouble(txtValorProducto.Text);

            Electrodomesticos oElectrodomesticos = new Electrodomesticos();

            oElectrodomesticos.EntregaProducto = EntregaProducto;
            oElectrodomesticos.ValorProducto = ValorProducto;

            oElectrodomesticos.CalcularValorTotal();

            lblValorSinDescuento.Text = "$ " + oElectrodomesticos.ValorSinDescuento.ToString("#,###");
            lblValorDescuento.Text = "$ " + oElectrodomesticos.ValorDescuento.ToString("#,###");
            lblValorAntesIva.Text = "$ " + oElectrodomesticos.ValorAntesIva.ToString("#,###");
            lblValorIva.Text = "$ " + oElectrodomesticos.ValorIva.ToString("#,###");
            lblValorTotal.Text = "$ " + oElectrodomesticos.ValorTotal.ToString("#,###");
            lblError.Text = oElectrodomesticos.Error;

            oElectrodomesticos = null;
        }
    }
}