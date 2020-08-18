using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprobacion_de_una_materia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnconsultar_Click(object sender, EventArgs e)
        {


            if (txtnota1.Text == "" || txtnota2.Text == "" || txtnota3.Text == "" || txtnota4.Text == "" || txtnota5.Text == "")

            {
                MessageBox.Show("Todos los campos deben estar diligenciados", "Mensaje de validacíon",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double nota1, nota2, nota3, nota4, nota5, suma, promedio;
                nota1 = double.Parse(txtnota1.Text);
                nota2 = double.Parse(txtnota2.Text);
                nota3 = double.Parse(txtnota3.Text);
                nota4 = double.Parse(txtnota4.Text);
                nota5 = double.Parse(txtnota5.Text);
                suma = nota1 + nota2 + nota3 + nota4 + nota5;
                promedio = suma / 5;
                if (nota1 < 0 || nota1 > 5 || nota2 < 0 || nota2 > 5 || nota3 < 0 || nota3 > 5 || nota4 < 0 || nota4 > 5 || nota5 < 0 || nota5 > 5)
                {
                    MessageBox.Show("Uno o varios campos no estan registrados correctamente,recuerde que cada examen es calificado de 0 hasta 5","Mensaje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                }
                 else if (promedio >= 0 && promedio <= 1)
                 { 
                    label7.Text = Convert.ToString(promedio + " *Reprueba la materia sin opción de recuperación*");
                    label7.Visible = true;
                    label6.Visible = true;
                 }
                else if (promedio > 1 && promedio <= 2.9)
                {
                    label7.Text = Convert.ToString(promedio + " *Reprueba la materia con opción de habilitar*");
                    label7.Visible = true;
                    label6.Visible = true;
                }
                else if (promedio >= 3 && promedio <= 3.9)
                {
                    label7.Text = Convert.ToString(promedio + " *Aprueba la materia;pero debe mejorar en algunos aspectos*");
                    label7.Visible = true;
                    label6.Visible = true;
                }
                else if (promedio >= 4 && promedio <= 4.5)
                {
                    label7.Text = Convert.ToString(promedio + " *Buen rendimiento*");
                    label7.Visible = true;
                    label6.Visible = true;
                }
                else if (promedio >= 4.6 && promedio <= 4.9)
                {
                    label7.Text = Convert.ToString(promedio + " *Excelente*");
                    label7.Visible = true;
                    label6.Visible = true;
                }
                else if (promedio <= 5)
                {
                    label7.Text = Convert.ToString(promedio + " *Graduado con honores*");
                    label7.Visible = true;
                    label6.Visible = true;
                }
            } 
        }

      

        private void txtnota1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255)||(e.KeyChar==47))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtnota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtnota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e. KeyChar <=45) || (e.KeyChar >=58 && e.KeyChar<=255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtnota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtnota5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtnota3.Text = String.Empty;
            txtnota4.Text = String.Empty;
            txtnota5.Text = String.Empty;
            label6.Text = String.Empty;
            label7.Text = String.Empty;
            txtnota1.Focus();
           
        }
    }
}
