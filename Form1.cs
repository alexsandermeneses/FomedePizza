using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleTelepizza
{
    public partial class formJaneiro2023 : Form
    {
        public formJaneiro2023()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia1, dia2, dia3, dia4, dia5, dia6, dia7, dia8, dia9, dia10, dia11, dia12, dia13,
                dia14, dia15, dia16, dia17, dia18, dia19, dia20, dia21, dia22, dia23, dia24, dia25,
                dia26, dia27, dia28, dia29, dia30, dia31, quantidadeEntregas;

            decimal valorEntregas, totalGorjetas, valorTotal;

            dia1 = int.Parse(txtDia1.Text);
            dia2 = int.Parse(txtDia2.Text);
            dia3 = int.Parse(txtDia3.Text);
            dia4 = int.Parse(txtDia4.Text);
            dia5 = int.Parse(txtDia5.Text);
            dia6 = int.Parse(txtDia6.Text);
            dia7 = int.Parse(txtDia7.Text);
            dia8 = int.Parse(txtDia8.Text);
            dia9 = int.Parse(txtDia9.Text);

            quantidadeEntregas = dia1 + dia2 + dia3;


            lblQuantidadeEntregas.Text = Convert.ToString(quantidadeEntregas);
        }
    }
}
