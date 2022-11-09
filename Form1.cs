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
    public partial class formFevereiro2023 : Form
    {
        public formFevereiro2023()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia1, dia2, dia3, dia4, dia5, dia6, dia7, dia8, dia9, dia10, dia11, dia12, dia13,
                dia14, dia15, dia16, dia17, dia18, dia19, dia20, dia21, dia22, dia23, dia24, dia25,
                dia26, dia27, dia28, dia29, dia30, dia31, quantidadeEntregas;

            decimal gorjetaDia1, gorjetaDia2, gorjetaDia3, gorjetaDia4, gorjetaDia5, gorjetaDia6,
                gorjetaDia7, gorjetaDia8, gorjetaDia9, gorjetaDia10, gorjetaDia11, gorjetaDia12,
                gorjetaDia13, gorjetaDia14, gorjetaDia15, gorjetaDia16, gorjetaDia17, gorjetaDia18,
                gorjetaDia19, gorjetaDia20, gorjetaDia21, gorjetaDia22, gorjetaDia23, gorjetaDia24,
                gorjetaDia25, gorjetaDia26, gorjetaDia27, gorjetaDia28, gorjetaDia29, gorjetaDia30,
                gorjetaDia31, valorEntregas, totalGorjetas, valorTotal;

            dia1 = int.Parse(txtDia1.Text);
            dia2 = int.Parse(txtDia2.Text);
            dia3 = int.Parse(txtDia3.Text);
            dia4 = int.Parse(txtDia4.Text);
            dia5 = int.Parse(txtDia5.Text);
            dia6 = int.Parse(txtDia6.Text);
            dia7 = int.Parse(txtDia7.Text);
            dia8 = int.Parse(txtDia8.Text);
            dia9 = int.Parse(txtDia9.Text);
            dia10 = int.Parse(txtDia10.Text);
            dia11 = int.Parse(txtDia11.Text);
            dia12 = int.Parse(txtDia12.Text);
            dia13 = int.Parse(txtDia13.Text);
            dia14 = int.Parse(txtDia14.Text);
            dia15 = int.Parse(txtDia15.Text);
            dia16 = int.Parse(txtDia16.Text);
            dia17 = int.Parse(txtDia17.Text);
            dia18 = int.Parse(txtDia18.Text);
            dia19 = int.Parse(txtDia19.Text);
            dia20 = int.Parse(txtDia20.Text);
            dia21 = int.Parse(txtDia21.Text);
            dia22 = int.Parse(txtDia22.Text);
            dia23 = int.Parse(txtDia23.Text);
            dia24 = int.Parse(txtDia24.Text);
            dia25 = int.Parse(txtDia25.Text);
            dia26 = int.Parse(txtDia26.Text);
            dia27 = int.Parse(txtDia27.Text);
            dia28 = int.Parse(txtDia28.Text);
            dia29 = int.Parse(txtDia29.Text);
            dia30 = int.Parse(txtDia30.Text);
            dia31 = int.Parse(txtDia31.Text);

            quantidadeEntregas = dia1 + dia2 + dia3 + dia4 + dia5 + dia6 + dia7 + dia8 + dia9 + dia10 +
                dia11 + dia12 + dia13 + dia14 + dia15 + dia16 + dia17 + dia18 + dia19 + dia20 + dia21 +
                dia22 + dia23 + dia24 + dia25 + dia26 + dia27 + dia28 + dia29 + dia30 + dia31;

            gorjetaDia1 = decimal.Parse(txtGorjetaDia1.Text);
            gorjetaDia2 = decimal.Parse(txtGorjetaDia2.Text);
            gorjetaDia3 = decimal.Parse(txtGorjetaDia3.Text);
            gorjetaDia4 = decimal.Parse(txtGorjetaDia4.Text);
            gorjetaDia5 = decimal.Parse(txtGorjetaDia5.Text);
            gorjetaDia6 = decimal.Parse(txtGorjetaDia6.Text);
            gorjetaDia7 = decimal.Parse(txtGorjetaDia7.Text);
            gorjetaDia8 = decimal.Parse(txtGorjetaDia8.Text);
            gorjetaDia9 = decimal.Parse(txtGorjetaDia9.Text);
            gorjetaDia10 = decimal.Parse(txtGorjetaDia10.Text);
            gorjetaDia11 = decimal.Parse(txtGorjetaDia11.Text);
            gorjetaDia12 = decimal.Parse(txtGorjetaDia12.Text);
            gorjetaDia13 = decimal.Parse(txtGorjetaDia13.Text);
            gorjetaDia14 = decimal.Parse(txtGorjetaDia14.Text);
            gorjetaDia15 = decimal.Parse(txtGorjetaDia15.Text);
            gorjetaDia16 = decimal.Parse(txtGorjetaDia16.Text);
            gorjetaDia17 = decimal.Parse(txtGorjetaDia17.Text);
            gorjetaDia18 = decimal.Parse(txtGorjetaDia18.Text);
            gorjetaDia19 = decimal.Parse(txtGorjetaDia19.Text);
            gorjetaDia20 = decimal.Parse(txtGorjetaDia20.Text);
            gorjetaDia21 = decimal.Parse(txtGorjetaDia21.Text);
            gorjetaDia22 = decimal.Parse(txtGorjetaDia22.Text);
            gorjetaDia23 = decimal.Parse(txtGorjetaDia23.Text);
            gorjetaDia24 = decimal.Parse(txtGorjetaDia24.Text);
            gorjetaDia25 = decimal.Parse(txtGorjetaDia25.Text);
            gorjetaDia26 = decimal.Parse(txtGorjetaDia26.Text);
            gorjetaDia27 = decimal.Parse(txtGorjetaDia27.Text);
            gorjetaDia28 = decimal.Parse(txtGorjetaDia28.Text);
            gorjetaDia29 = decimal.Parse(txtGorjetaDia29.Text);
            gorjetaDia30 = decimal.Parse(txtGorjetaDia30.Text);
            gorjetaDia31 = decimal.Parse(txtGorjetaDia31.Text);

            totalGorjetas = gorjetaDia1 + gorjetaDia2 + gorjetaDia3 + gorjetaDia4 + gorjetaDia5 +  gorjetaDia6 + gorjetaDia7 + gorjetaDia8 + gorjetaDia9 + gorjetaDia10 + gorjetaDia11 + gorjetaDia12 + gorjetaDia13 + gorjetaDia14 + gorjetaDia15 + gorjetaDia16 + gorjetaDia17 + gorjetaDia18 + gorjetaDia19 + gorjetaDia20 + gorjetaDia21 + gorjetaDia22 + gorjetaDia23 + gorjetaDia24 + gorjetaDia25 + gorjetaDia26 + gorjetaDia27 + gorjetaDia28 + gorjetaDia29 + gorjetaDia30 + gorjetaDia31;

            valorEntregas = quantidadeEntregas * 0.35m;


            lblQuantidadeEntregas.Text = quantidadeEntregas.ToString();
            lblValorEntregas.Text = valorEntregas.ToString("C");
            lblTotalGorjeta.Text = totalGorjetas.ToString("C");

            valorTotal = valorEntregas + totalGorjetas;
            lblValorTotal.Text = valorTotal.ToString("C");
        }
    }
}
