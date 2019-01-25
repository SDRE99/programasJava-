using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tragaperras
{
    public partial class f_Tragaperras : Form
    {

        String[] frutas = { "cereza", "ciruela", "fresa", "limon", "manzana", "melon", "naranja", "piña", "platano" };
        int xogadasRestantes;
        int posicionFrutas1;
        int posicionFrutas2;
        int posicionFrutas3;

        public f_Tragaperras()
        {
            InitializeComponent();
            lblPremioConseguido.Visible = false;
        }

        private void btXogar_Click(object sender, EventArgs e)
        {
            btXogar.Enabled = false;
            btAcumular.Enabled = false;
            btCobrarAcumulado.Enabled = false;
            btCobrarPremio.Enabled = false;

            btConvertir.Enabled = false;
            lblCuadroNegro.Text = Convert.ToString(Convert.ToInt32(lblCuadroNegro.Text) - 1);
            btDeter.Enabled = true;
            Temporizador.Enabled = true;

        }

        private void bt20cent_Click(object sender, EventArgs e)
        {
            if (lblCuadroNegro.Text == "")
            {
                lblCuadroNegro.Text = "0";
            }

            xogadasRestantes = Convert.ToInt32(lblCuadroNegro.Text);

            lblCuadroNegro.Text = Convert.ToString(xogadasRestantes + 2);

            btXogar.Enabled = true;
        }

        private void bt50cent_Click(object sender, EventArgs e)
        {
            if (lblCuadroNegro.Text == "")
            {
                lblCuadroNegro.Text = "0";
            }
            xogadasRestantes = Convert.ToInt32(lblCuadroNegro.Text);

            lblCuadroNegro.Text = Convert.ToString(xogadasRestantes + 5);

            btXogar.Enabled = true;
        }

        private void bt1euro_Click(object sender, EventArgs e)
        {
            if (lblCuadroNegro.Text == "")
            {
                lblCuadroNegro.Text = "0";
            }

            xogadasRestantes = Convert.ToInt32(lblCuadroNegro.Text);

            lblCuadroNegro.Text = Convert.ToString(xogadasRestantes + 10);

            btXogar.Enabled = true;
        }

        private void bt2euros_Click(object sender, EventArgs e)
        {
            if (lblCuadroNegro.Text == "")
            {
                lblCuadroNegro.Text = "0";
            }

            xogadasRestantes = Convert.ToInt32(lblCuadroNegro.Text);

            lblCuadroNegro.Text = Convert.ToString(xogadasRestantes + 20);

            btXogar.Enabled = true;
        }

        private void btDeter_Click(object sender, EventArgs e)
        {
            btDeter.Enabled = false;
            Temporizador.Enabled = false;
            //Calculamos os premios: 
            calculoPremios(posicionFrutas1, posicionFrutas2, posicionFrutas3);
            if ((lblAcumulado.Text != "") && (lblAcumulado.Text != "0"))
            {
                btCobrarAcumulado.Enabled = true;
                btConvertir.Enabled = true;
            }
            if ((lblPremio.Text != "") && (lblPremio.Text != "0"))
            {
                btCobrarPremio.Enabled = true;
                btAcumular.Enabled = true;
            }

            if (lblCuadroNegro.Text == "0")
            {
                btXogar.Enabled = false;
            } else 
            btXogar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            posicionFrutas1 = r.Next(9);
            pbFruta1.Image = Image.FromFile("G:/2DAM/DEIN/UD1/Visual Studio/014_Tragaperras/imagenes/" + frutas[posicionFrutas1] + ".jpg");
            posicionFrutas2 = r.Next(9);
            pbFruta2.Image = Image.FromFile("G:/2DAM/DEIN/UD1/Visual Studio/014_Tragaperras/imagenes/" + frutas[posicionFrutas2] + ".jpg");
            posicionFrutas3 = r.Next(9);
            pbFruta3.Image = Image.FromFile("G:/2DAM/DEIN/UD1/Visual Studio/014_Tragaperras/imagenes/" + frutas[posicionFrutas3] + ".jpg");
        }

        private void calculoPremios(int posicionFrutas, int posicionFrutas2, int posicionFrutas3)
        {
            if ((posicionFrutas == 0) && (posicionFrutas2 == 0) && (posicionFrutas3 == 0))
            {
                if (lblPremio.Text == "")
                {
                    lblPremio.Text = "0";
                }
                lblPremio.Text = Convert.ToString(Convert.ToInt32(lblPremio.Text) + 50);
            }
            else if ((posicionFrutas == posicionFrutas2) && (posicionFrutas2 == posicionFrutas3))
            {
                if (lblPremio.Text == "")
                {
                    lblPremio.Text = "0";
                }
                lblPremio.Text = Convert.ToString(Convert.ToInt32(lblPremio.Text) + 10);

            }
            else if ((posicionFrutas1 == posicionFrutas2) || (posicionFrutas1 == posicionFrutas3) || (posicionFrutas2 == posicionFrutas3))
            {
                if (lblPremio.Text == "")
                {
                    lblPremio.Text = "0";
                }
                lblPremio.Text = Convert.ToString(Convert.ToInt32(lblPremio.Text) + 5);
            }
        }

        private void btAcumular_Click(object sender, EventArgs e)
        {
            btAcumular.Enabled = false;
            btCobrarPremio.Enabled = false;
            btCobrarAcumulado.Enabled = true;
            btConvertir.Enabled = true;
            int acumulacion = Convert.ToInt32(lblAcumulado.Text) + Convert.ToInt32(lblPremio.Text);
            lblAcumulado.Text = Convert.ToString(acumulacion);
            lblPremio.Text = "0";
        }

        private void btCobrarPremio_Click(object sender, EventArgs e)
        {
            btCobrarPremio.Enabled = false;
            btAcumular.Enabled = false;
            lblPremio.Text = "0";
            lblPremioConseguido.Visible = true;
        }

        private void btCobrarAcumulado_Click(object sender, EventArgs e)
        {
            btCobrarAcumulado.Enabled = false;
            btConvertir.Enabled = false;
            lblAcumulado.Text = "0";
            lblPremioConseguido.Visible = true;
        }

        private void btConvertir_Click(object sender, EventArgs e)
        {
            btConvertir.Enabled = false;
            btCobrarAcumulado.Enabled = false;
            int xogadasRestantes = Convert.ToInt32(lblCuadroNegro.Text);
            int acumulado = Convert.ToInt32(lblAcumulado.Text);
            int xogadas = (xogadasRestantes + acumulado);
            lblCuadroNegro.Text = Convert.ToString(xogadas);
            lblAcumulado.Text = "0";
        }
        
        private void lblPremioConseguido_Click(object sender, EventArgs e)
        {
            lblPremioConseguido.Visible = false;
        }
    }
}
