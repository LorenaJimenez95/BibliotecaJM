namespace BibliotecaJM
{
    partial class FM_Prestamos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbBuscarLibro = new System.Windows.Forms.GroupBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bRealizarPrestamo = new System.Windows.Forms.Button();
            this.bBUscarAutor = new System.Windows.Forms.Button();
            this.bBuscarTitulo = new System.Windows.Forms.Button();
            this.bBuscarIdentificador = new System.Windows.Forms.Button();
            this.gbBusquedaLector = new System.Windows.Forms.GroupBox();
            this.bBuscarNombreLector = new System.Windows.Forms.Button();
            this.bBuscarIDLector = new System.Windows.Forms.Button();
            this.txNombreLector = new System.Windows.Forms.TextBox();
            this.txIdLector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager2 = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbBuscarLibro.SuspendLayout();
            this.gbBusquedaLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarLibro
            // 
            this.gbBuscarLibro.Controls.Add(this.librosDataGridView);
            this.gbBuscarLibro.Controls.Add(this.tbAutor);
            this.gbBuscarLibro.Controls.Add(this.tbTitulo);
            this.gbBuscarLibro.Controls.Add(this.tbIdentificador);
            this.gbBuscarLibro.Controls.Add(this.label5);
            this.gbBuscarLibro.Controls.Add(this.label4);
            this.gbBuscarLibro.Controls.Add(this.label3);
            this.gbBuscarLibro.Controls.Add(this.bRealizarPrestamo);
            this.gbBuscarLibro.Controls.Add(this.bBUscarAutor);
            this.gbBuscarLibro.Controls.Add(this.bBuscarTitulo);
            this.gbBuscarLibro.Controls.Add(this.bBuscarIdentificador);
            this.gbBuscarLibro.Location = new System.Drawing.Point(461, 53);
            this.gbBuscarLibro.Name = "gbBuscarLibro";
            this.gbBuscarLibro.Size = new System.Drawing.Size(537, 594);
            this.gbBuscarLibro.TabIndex = 4;
            this.gbBuscarLibro.TabStop = false;
            this.gbBuscarLibro.Text = "Buscar Libro";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(167, 79);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(170, 20);
            this.tbAutor.TabIndex = 10;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(167, 52);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(170, 20);
            this.tbTitulo.TabIndex = 9;
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(167, 29);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(170, 20);
            this.tbIdentificador.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identificador";
            // 
            // bRealizarPrestamo
            // 
            this.bRealizarPrestamo.Location = new System.Drawing.Point(21, 551);
            this.bRealizarPrestamo.Name = "bRealizarPrestamo";
            this.bRealizarPrestamo.Size = new System.Drawing.Size(491, 23);
            this.bRealizarPrestamo.TabIndex = 3;
            this.bRealizarPrestamo.Text = "Realizar Prestamo";
            this.bRealizarPrestamo.UseVisualStyleBackColor = true;
            this.bRealizarPrestamo.Click += new System.EventHandler(this.bRealizarPrestamo_Click);
            // 
            // bBUscarAutor
            // 
            this.bBUscarAutor.Location = new System.Drawing.Point(437, 86);
            this.bBUscarAutor.Name = "bBUscarAutor";
            this.bBUscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBUscarAutor.TabIndex = 2;
            this.bBUscarAutor.Text = "Buscar";
            this.bBUscarAutor.UseVisualStyleBackColor = true;
            this.bBUscarAutor.Click += new System.EventHandler(this.bBUscarAutor_Click);
            // 
            // bBuscarTitulo
            // 
            this.bBuscarTitulo.Location = new System.Drawing.Point(437, 56);
            this.bBuscarTitulo.Name = "bBuscarTitulo";
            this.bBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTitulo.TabIndex = 1;
            this.bBuscarTitulo.Text = "Buscar";
            this.bBuscarTitulo.UseVisualStyleBackColor = true;
            this.bBuscarTitulo.Click += new System.EventHandler(this.bBuscarTitulo_Click);
            // 
            // bBuscarIdentificador
            // 
            this.bBuscarIdentificador.Location = new System.Drawing.Point(437, 25);
            this.bBuscarIdentificador.Name = "bBuscarIdentificador";
            this.bBuscarIdentificador.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIdentificador.TabIndex = 0;
            this.bBuscarIdentificador.Text = "Buscar";
            this.bBuscarIdentificador.UseVisualStyleBackColor = true;
            this.bBuscarIdentificador.Click += new System.EventHandler(this.bBuscarIdentificador_Click);
            // 
            // gbBusquedaLector
            // 
            this.gbBusquedaLector.Controls.Add(id_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.id_lecLabel1);
            this.gbBusquedaLector.Controls.Add(nombre_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.nombre_lecLabel1);
            this.gbBusquedaLector.Controls.Add(domicilio_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.domicilio_lecLabel1);
            this.gbBusquedaLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.gbBusquedaLector.Controls.Add(this.bBuscarNombreLector);
            this.gbBusquedaLector.Controls.Add(this.bBuscarIDLector);
            this.gbBusquedaLector.Controls.Add(this.txNombreLector);
            this.gbBusquedaLector.Controls.Add(this.txIdLector);
            this.gbBusquedaLector.Controls.Add(this.label2);
            this.gbBusquedaLector.Controls.Add(this.label1);
            this.gbBusquedaLector.Location = new System.Drawing.Point(12, 53);
            this.gbBusquedaLector.Name = "gbBusquedaLector";
            this.gbBusquedaLector.Size = new System.Drawing.Size(428, 257);
            this.gbBusquedaLector.TabIndex = 3;
            this.gbBusquedaLector.TabStop = false;
            this.gbBusquedaLector.Text = "Busqueda Lector";
            // 
            // bBuscarNombreLector
            // 
            this.bBuscarNombreLector.Location = new System.Drawing.Point(301, 52);
            this.bBuscarNombreLector.Name = "bBuscarNombreLector";
            this.bBuscarNombreLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombreLector.TabIndex = 5;
            this.bBuscarNombreLector.Text = "Buscar";
            this.bBuscarNombreLector.UseVisualStyleBackColor = true;
            this.bBuscarNombreLector.Click += new System.EventHandler(this.bBuscarNombreLector_Click);
            // 
            // bBuscarIDLector
            // 
            this.bBuscarIDLector.Location = new System.Drawing.Point(301, 25);
            this.bBuscarIDLector.Name = "bBuscarIDLector";
            this.bBuscarIDLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIDLector.TabIndex = 4;
            this.bBuscarIDLector.Text = "Buscar";
            this.bBuscarIDLector.UseVisualStyleBackColor = true;
            this.bBuscarIDLector.Click += new System.EventHandler(this.bBuscarIDLector_Click);
            // 
            // txNombreLector
            // 
            this.txNombreLector.Location = new System.Drawing.Point(82, 56);
            this.txNombreLector.Name = "txNombreLector";
            this.txNombreLector.Size = new System.Drawing.Size(168, 20);
            this.txNombreLector.TabIndex = 3;
            // 
            // txIdLector
            // 
            this.txIdLector.Location = new System.Drawing.Point(82, 29);
            this.txIdLector.Name = "txIdLector";
            this.txIdLector.Size = new System.Drawing.Size(168, 20);
            this.txIdLector.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Lector";
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(12, 334);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(423, 313);
            this.librosPrestadosDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(21, 178);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.Size = new System.Drawing.Size(491, 326);
            this.librosDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "autor_lib";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn8.HeaderText = "seccion_lib";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.HeaderText = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager2.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(24, 133);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(35, 13);
            id_lecLabel.TabIndex = 6;
            id_lecLabel.Text = "id lec:";
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(146, 133);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_lecLabel1.TabIndex = 7;
            this.id_lecLabel1.Text = "label6";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(24, 156);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(62, 13);
            nombre_lecLabel.TabIndex = 8;
            nombre_lecLabel.Text = "nombre lec:";
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(146, 156);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.nombre_lecLabel1.TabIndex = 9;
            this.nombre_lecLabel1.Text = "label6";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(24, 179);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(67, 13);
            domicilio_lecLabel.TabIndex = 10;
            domicilio_lecLabel.Text = "domicilio lec:";
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(146, 179);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.domicilio_lecLabel1.TabIndex = 11;
            this.domicilio_lecLabel1.Text = "label6";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(24, 202);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(116, 13);
            fecha_penalizacion_lecLabel.TabIndex = 18;
            fecha_penalizacion_lecLabel.Text = "fecha penalizacion lec:";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(148, 202);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 19;
            this.fecha_penalizacion_lecLabel1.Text = "label6";
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1018, 700);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.gbBuscarLibro);
            this.Controls.Add(this.gbBusquedaLector);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.gbBuscarLibro.ResumeLayout(false);
            this.gbBuscarLibro.PerformLayout();
            this.gbBusquedaLector.ResumeLayout(false);
            this.gbBusquedaLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBuscarLibro;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bRealizarPrestamo;
        private System.Windows.Forms.Button bBUscarAutor;
        private System.Windows.Forms.Button bBuscarTitulo;
        private System.Windows.Forms.Button bBuscarIdentificador;
        private System.Windows.Forms.GroupBox gbBusquedaLector;
        private System.Windows.Forms.Button bBuscarNombreLector;
        private System.Windows.Forms.Button bBuscarIDLector;
        private System.Windows.Forms.TextBox txNombreLector;
        private System.Windows.Forms.TextBox txIdLector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private DS_LibrosPrestadosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
    }
}
