using RegistroArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulo.UI.Consultas
{
    public partial class cArticulos : Form
    {
        public cArticulos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> Filtro = x => true;

            int id;
            switch(FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    Filtro = x => x.ArticulosId == id;
                    break;
                case 1:
                    Filtro = x => x.FechaVencimiento.Equals(CriteriotextBox.Text);
                    break;
                case 2:
                    Filtro = x => x.Descripcion.Equals(CriteriotextBox.Text);
                    break;
                case 3:
                    Filtro = x => x.Precio.Equals(CriteriotextBox.Text);
                    break;
                case 4:
                    Filtro = x => x.Existencia.Equals(CriteriotextBox.Text);
                    break;
                case 5:
                    Filtro = x => x.CantidadCotizada.Equals(CriteriotextBox.Text);
                    break;
            }
            ConsultadataGridView.DataSource = BLL.ArticulosBLL.GetList(Filtro);
        }

        private void cArticulos_Load(object sender, EventArgs e)
        {

        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
