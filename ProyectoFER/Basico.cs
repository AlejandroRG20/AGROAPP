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
    public partial class Basico : Form
    {
        
        public Basico()
        {
            InitializeComponent();
        }

        private void Basico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio back = new Inicio();
            back.Show();
            
        }
    }
}
