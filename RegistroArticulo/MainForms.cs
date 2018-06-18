using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulo
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rArticulos rA = new UI.Registro.rArticulos();
            rA.Show();
        }

        private void MainForms_Load(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cArticulos cA = new UI.Consultas.cArticulos();
            cA.Show();
        }

        private void registroDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rArticulos rA = new UI.Registro.rArticulos();
            rA.Show();
        }
    }
}
