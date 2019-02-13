using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_LibrosPrestados.LibrosPrestados' Puede moverla o quitarla según sea necesario.
            this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);

        }

        private void bBuscarIDLector_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillById(this.dS_Lectores.lectores, int.Parse(txIdLector.Text));
            this.librosPrestadosTableAdapter.FillById(this.dS_LibrosPrestados.LibrosPrestados, int.Parse(txIdLector.Text));
        }

        private void bBuscarNombreLector_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillByNombre(this.dS_Lectores.lectores, txNombreLector.Text);
            this.librosPrestadosTableAdapter.FillByNombre(this.dS_LibrosPrestados.LibrosPrestados, txNombreLector.Text);
        }

        private void bRealizarPrestamo_Click(object sender, EventArgs e)
        {
            txIdLector.Focus();
            string prestamo = "";

            int posicion = librosBindingSource.Position;
            prestamo = dS_Libros.libros[posicion].prestado_sn_lib;
            if (txIdLector.Text != "")
            {
                if (prestamo.Contains("N"))
                {
                    DS_Configuracion.configuracionDataTable confiDt = new DS_Configuracion.configuracionDataTable();
                    DS_ConfiguracionTableAdapters.configuracionTableAdapter configTa = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();
                    configTa.Fill(confiDt);
                    DS_Prestamos.prestamosDataTable prestamosDt = new DS_Prestamos.prestamosDataTable();
                    DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTa = new DS_PrestamosTableAdapters.prestamosTableAdapter();
                    DS_Prestamos.prestamosRow fila = prestamosDt.NewprestamosRow();
                    fila.id_lec_pre = dS_Lectores.lectores[0].id_lec;
                    fila.id_lib_pre = dS_Libros.libros[posicion].id_lib;
                    fila.fecha_presta_pre = DateTime.Now;
                    fila.fecha_devol_pre = DateTime.Now.AddDays(confiDt[0].dias_prestamo_cnf);
                    prestamosDt.AddprestamosRow(fila);
                    prestamosTa.Update(prestamosDt);
                    //librosPrestadosDataGridView.Update();
                    librosPrestadosTableAdapter.FillById(dS_LibrosPrestados.LibrosPrestados, int.Parse(txIdLector.Text));
                    dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull().Equals(null);
                    dS_Libros.libros[posicion].prestado_sn_lib.Remove(0);
                    dS_Libros.libros[posicion].prestado_sn_lib = "S";
                    librosBindingSource.EndEdit();
                    librosTableAdapter.Update(dS_Libros.libros);
                    librosDataGridView.Update();
                    MessageBox.Show("El prestamo se ha realizado correctamente");
                }
                else
                {
                    MessageBox.Show("Este libro ya esta prestado, lo siento");
                }
            }
            else
            {
                MessageBox.Show("Primero tienes que buscar al lector");

            }
        }
    

        private void bBuscarIdentificador_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillById(this.dS_Libros.libros, int.Parse(tbIdentificador.Text));
        }

        private void bBuscarTitulo_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByTitulo(this.dS_Libros.libros, tbTitulo.Text);
        }

        private void bBUscarAutor_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByAutor(this.dS_Libros.libros, tbAutor.Text);
        }
    }
}
