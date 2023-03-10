using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAJ
{
    public partial class Inicio : Form
    {
        Basico X = new Basico();
        Intermedio y = new Intermedio();
        Avanzado z = new Avanzado();
        public Inicio()
        {
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (chBasico.Checked == true)
            {
                X.Show();
                this.Hide();
            }
            else if (chIntermedio.Checked == true)
            {
                y.Show();
                this.Hide();
            }
            else if (chAvanzado.Checked == true)
            {
                z.Show();
                this.Hide();
            }
            else if ((chBasico.Text == "" && chIntermedio.Text == "") && chAvanzado.Text == "")
            {
                MessageBox.Show("Seleccione un nivel, Error");

            }

        }

        private void chBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (chBasico.Checked == true)
            {
                chIntermedio.Enabled = false;
                chAvanzado.Enabled = false;

            }
            else if (chBasico.Checked == false)
            {
                chIntermedio.Enabled = true;
                chAvanzado.Enabled = true;
            }
        }

        private void chIntermedio_CheckedChanged(object sender, EventArgs e)
        {
            if (chIntermedio.Checked == true)
            {
                chBasico.Enabled = false;
                chAvanzado.Enabled = false;

            }
            else if (chIntermedio.Checked == false)
            {
                chBasico.Enabled = true;
                chAvanzado.Enabled = true;
            }
        }

        private void chAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            if (chAvanzado.Checked == true)
            {
                chIntermedio.Enabled = false;
                chBasico.Enabled = false;

            }
            else if (chAvanzado.Checked == false)
            {
                chIntermedio.Enabled = true;
                chBasico.Enabled = true;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
