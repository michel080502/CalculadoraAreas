using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras_Areas_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelCirculo.Visible = false;
            panelCuadrado.Visible = false;
            panelRectangulo.Visible = false;
            panelTriangulo.Visible = false;
            panelRombo.Visible = false; 
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            mostrarPanel(panelCuadrado);
        }

        private void mostrarPanel(Panel panel)
        {
            panelCirculo.Visible = false;
            panelCuadrado.Visible = false;
            panelRectangulo.Visible = false;
            panelTriangulo.Visible = false;
            panelRombo.Visible = false;

            panel.Visible = true;
        }

        private void Circulo_Click(object sender, EventArgs e)
        {
            mostrarPanel(panelCirculo);
        }

        private void Rectangulo_Click(object sender, EventArgs e)
        {
            mostrarPanel(panelRectangulo); 
        }

        private void AreaCirculo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(radioCirculo.Text, out double radio))
            {
                if (radio>0)
                {
                    double area = Math.Round(Math.PI * Math.Pow(radio, 2),2);
                    AreaCir.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
            
        }

        private void PerimetroCirculo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(radioCirculo.Text, out double radio))
            {
                if (radio > 0)
                {
                    double perimetro = Math.Round(2 * Math.PI * radio,2);
                    PerimetroCir.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void AreaCuadrado_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ladoCuadrado.Text, out double lado))
            {
                if (lado > 0)
                {
                    double area = Math.Round(Math.Pow(lado, 2), 2);
                    AreaCua.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void PerimetroCuadrado_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ladoCuadrado.Text, out double lado))
            {
                if (lado > 0)
                {
                    double perimetro = Math.Round(4 * lado, 2);
                    PerimetroCua.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void AreaRectangulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(largoRectangulo.Text, out double largo) && double.TryParse(anchoRectangulo.Text, out double ancho))
            {
                if (largo > 0 && ancho > 0)
                {
                    double area = Math.Round(largo * ancho, 2);
                    AreacRec.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void PerimetroRectangulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(largoRectangulo.Text, out double largo) && double.TryParse(anchoRectangulo.Text, out double ancho))
            {
                if (largo > 0 && ancho > 0)
                {
                    double perimetro = Math.Round(2 * (largo + ancho), 2);
                    PerimetroRec.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void AreaTriangulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TrianguloBase.Text, out double bas) && double.TryParse(TrianguloAltura.Text, out double altura))
            {
                if (bas > 0 && altura > 0)
                {
                    double area = (bas * altura) / 2;
                    AreaTri.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void PerimetroTriangulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TrianguloBase.Text, out double bas) && double.TryParse(TrianguloAltura.Text, out double altura))
            {
                if (bas > 0 && altura > 0)
                {
                    double hipotenusa = Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(altura, 2));
                    double perimetro = bas + altura + hipotenusa;
                    PerimetroTri.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void AreaRombo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(DmayorRombo.Text, out double diagonalMayor) && double.TryParse(DmenorRombo.Text, out double diagonalMenor))
            {
                if (diagonalMayor  > 0 && diagonalMenor > 0)
                {
                    double area = (diagonalMayor * diagonalMenor) / 2;
                    AreaRom.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void PerimetroRombo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ladoRombo.Text, out double lado))
            {
                if (lado > 0)
                {
                    double perimetro = 4 * lado;
                    PerimetroRom.Text = perimetro.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa números positivos, por favor.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos, por favor.");
            }
        }

        private void Triangulo_Click(object sender, EventArgs e)
        {
            mostrarPanel(panelTriangulo);
        }

        private void Rombo_Click(object sender, EventArgs e)
        {
            mostrarPanel(panelRombo);
        }
    }
}
