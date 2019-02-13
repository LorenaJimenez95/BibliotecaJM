using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Libros : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Libros()
        {
            InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Libros);

        }

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            ModoBusqueda();
        }

        private void bBuscarID_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillById(dS_Libros.libros, int.Parse(tbID.Text));
        }

        private void bBuscarTitulo_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByTitulo(dS_Libros.libros, tbTitulo.Text);
        }

        private void bBuscarAutor_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutor.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            ModoEdicion();
            librosBindingSource.AddNew();
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
                    librosBindingSource.RemoveCurrent();
                    this.librosTableAdapter.Update(dS_Libros.libros);
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
                librosBindingSource.EndEdit();
                this.librosTableAdapter.Update(this.dS_Libros.libros);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la escritura de la base de datos");
            }
            ModoBusqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            librosBindingSource.EndEdit();
            ModoBusqueda();
        }

        void ModoBusqueda()
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }

        void ModoEdicion()
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void bSeccion_Click(object sender, EventArgs e)
        {
            Seccion seccion = new Seccion();
            seccion.ShowDialog();
            seccion_libTextBox.Text = seccion.nombreSeccion.ToString();
        }
    }
}
