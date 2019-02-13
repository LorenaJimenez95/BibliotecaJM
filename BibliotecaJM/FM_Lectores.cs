using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void lectoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lectoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Lectores);

        }

        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            ModoBusqueda();
        }

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillById(dS_Lectores.lectores, int.Parse(textBox1.Text));
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillByNombre(dS_Lectores.lectores, textBox2.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            this.lectoresBindingSource.AddNew();
            ModoEdicion();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModoEdicion();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    lectoresBindingSource.RemoveCurrent();
                    this.lectoresTableAdapter.Update(dS_Lectores.lectores);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en el borrado");
                }
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresBindingSource.EndEdit();
                this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la escritura de la base de datos");
            }
            ModoBusqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ModoBusqueda();
            lectoresBindingSource.CancelEdit();
        }

        private void bProvincias_Click(object sender, EventArgs e)
        {
            FM_provincias provi = new FM_provincias();
            provi.ShowDialog();
            provincia_lecTextBox.Text = provi.nombreProvincia;
        }

        private void ModoBusqueda()
        {
            gbBuscarLector.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void ModoEdicion()
        {
            gbBuscarLector.Enabled = false;
            groupBox2.Enabled = true;
        }
    }
}
