using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_provincias : Form
    {

        public string nombreProvincia { get; set; }

        public FM_provincias()
        {
            InitializeComponent();
        }

        private void provinciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.provinciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Provincias);

        }

        private void FM_provincias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);

        }

        private void provinciasDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = provinciasBindingSource.Position;
            nombreProvincia = dS_Provincias.provincias[posicion].provincia_pro;
            this.Close();
        }
    }
}
