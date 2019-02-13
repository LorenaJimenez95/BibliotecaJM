namespace BibliotecaJM
{
    partial class FM_Libros
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
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label prestado_sn_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label seccion_libLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSeccion = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.id_libLabel1 = new System.Windows.Forms.Label();
            this.prestado_sn_libTextBox = new System.Windows.Forms.TextBox();
            this.titulo_libLabel1 = new System.Windows.Forms.Label();
            this.seccion_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libLabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuscarAutor = new System.Windows.Forms.Button();
            this.bBuscarTitulo = new System.Windows.Forms.Button();
            this.bBuscarID = new System.Windows.Forms.Button();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            prestado_sn_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            seccion_libLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSeccion);
            this.groupBox2.Controls.Add(this.bCancelar);
            this.groupBox2.Controls.Add(this.bAceptar);
            this.groupBox2.Controls.Add(id_libLabel);
            this.groupBox2.Controls.Add(this.id_libLabel1);
            this.groupBox2.Controls.Add(this.prestado_sn_libTextBox);
            this.groupBox2.Controls.Add(titulo_libLabel);
            this.groupBox2.Controls.Add(prestado_sn_libLabel);
            this.groupBox2.Controls.Add(this.titulo_libLabel1);
            this.groupBox2.Controls.Add(this.seccion_libTextBox);
            this.groupBox2.Controls.Add(autor_libLabel);
            this.groupBox2.Controls.Add(seccion_libLabel);
            this.groupBox2.Controls.Add(this.autor_libLabel1);
            this.groupBox2.Location = new System.Drawing.Point(541, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 521);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bSeccion
            // 
            this.bSeccion.Location = new System.Drawing.Point(241, 188);
            this.bSeccion.Name = "bSeccion";
            this.bSeccion.Size = new System.Drawing.Size(47, 23);
            this.bSeccion.TabIndex = 12;
            this.bSeccion.Text = "...";
            this.bSeccion.UseVisualStyleBackColor = true;
            this.bSeccion.Click += new System.EventHandler(this.bSeccion_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(231, 430);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(67, 430);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(36, 118);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(31, 13);
            id_libLabel.TabIndex = 0;
            id_libLabel.Text = "id lib:";
            // 
            // id_libLabel1
            // 
            this.id_libLabel1.Location = new System.Drawing.Point(120, 118);
            this.id_libLabel1.Name = "id_libLabel1";
            this.id_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_libLabel1.TabIndex = 1;
            this.id_libLabel1.Text = "label1";
            // 
            // prestado_sn_libTextBox
            // 
            this.prestado_sn_libTextBox.Location = new System.Drawing.Point(120, 216);
            this.prestado_sn_libTextBox.Name = "prestado_sn_libTextBox";
            this.prestado_sn_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.prestado_sn_libTextBox.TabIndex = 9;
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(36, 141);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(45, 13);
            titulo_libLabel.TabIndex = 2;
            titulo_libLabel.Text = "titulo lib:";
            // 
            // prestado_sn_libLabel
            // 
            prestado_sn_libLabel.AutoSize = true;
            prestado_sn_libLabel.Location = new System.Drawing.Point(36, 219);
            prestado_sn_libLabel.Name = "prestado_sn_libLabel";
            prestado_sn_libLabel.Size = new System.Drawing.Size(78, 13);
            prestado_sn_libLabel.TabIndex = 8;
            prestado_sn_libLabel.Text = "prestado sn lib:";
            // 
            // titulo_libLabel1
            // 
            this.titulo_libLabel1.Location = new System.Drawing.Point(120, 141);
            this.titulo_libLabel1.Name = "titulo_libLabel1";
            this.titulo_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.titulo_libLabel1.TabIndex = 3;
            this.titulo_libLabel1.Text = "label1";
            // 
            // seccion_libTextBox
            // 
            this.seccion_libTextBox.Location = new System.Drawing.Point(120, 190);
            this.seccion_libTextBox.Name = "seccion_libTextBox";
            this.seccion_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.seccion_libTextBox.TabIndex = 7;
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(36, 164);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(47, 13);
            autor_libLabel.TabIndex = 4;
            autor_libLabel.Text = "autor lib:";
            // 
            // seccion_libLabel
            // 
            seccion_libLabel.AutoSize = true;
            seccion_libLabel.Location = new System.Drawing.Point(36, 193);
            seccion_libLabel.Name = "seccion_libLabel";
            seccion_libLabel.Size = new System.Drawing.Size(60, 13);
            seccion_libLabel.TabIndex = 6;
            seccion_libLabel.Text = "seccion lib:";
            // 
            // autor_libLabel1
            // 
            this.autor_libLabel1.Location = new System.Drawing.Point(120, 164);
            this.autor_libLabel1.Name = "autor_libLabel1";
            this.autor_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.autor_libLabel1.TabIndex = 5;
            this.autor_libLabel1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.librosDataGridView);
            this.groupBox1.Controls.Add(this.bBuscarAutor);
            this.groupBox1.Controls.Add(this.bBuscarTitulo);
            this.groupBox1.Controls.Add(this.bBuscarID);
            this.groupBox1.Controls.Add(this.tbAutor);
            this.groupBox1.Controls.Add(this.tbTitulo);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bModificar);
            this.groupBox1.Controls.Add(this.bNuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 521);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bBuscarAutor
            // 
            this.bBuscarAutor.Location = new System.Drawing.Point(319, 91);
            this.bBuscarAutor.Name = "bBuscarAutor";
            this.bBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBuscarAutor.TabIndex = 12;
            this.bBuscarAutor.Text = "Buscar";
            this.bBuscarAutor.UseVisualStyleBackColor = true;
            this.bBuscarAutor.Click += new System.EventHandler(this.bBuscarAutor_Click);
            // 
            // bBuscarTitulo
            // 
            this.bBuscarTitulo.Location = new System.Drawing.Point(319, 62);
            this.bBuscarTitulo.Name = "bBuscarTitulo";
            this.bBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTitulo.TabIndex = 11;
            this.bBuscarTitulo.Text = "Buscar";
            this.bBuscarTitulo.UseVisualStyleBackColor = true;
            this.bBuscarTitulo.Click += new System.EventHandler(this.bBuscarTitulo_Click);
            // 
            // bBuscarID
            // 
            this.bBuscarID.Location = new System.Drawing.Point(319, 32);
            this.bBuscarID.Name = "bBuscarID";
            this.bBuscarID.Size = new System.Drawing.Size(75, 23);
            this.bBuscarID.TabIndex = 10;
            this.bBuscarID.Text = "Buscar";
            this.bBuscarID.UseVisualStyleBackColor = true;
            this.bBuscarID.Click += new System.EventHandler(this.bBuscarID_Click);
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(129, 95);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(169, 20);
            this.tbAutor.TabIndex = 9;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(129, 64);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(169, 20);
            this.tbTitulo.TabIndex = 8;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(129, 32);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(169, 20);
            this.tbID.TabIndex = 7;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(319, 428);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 6;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(170, 429);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 5;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(18, 430);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 4;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(18, 141);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.Size = new System.Drawing.Size(445, 220);
            this.librosDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn3.HeaderText = "autor_lib";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn4.HeaderText = "seccion_lib";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Libros";
            this.Load += new System.EventHandler(this.FM_Libros_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSeccion;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label id_libLabel1;
        private System.Windows.Forms.TextBox prestado_sn_libTextBox;
        private System.Windows.Forms.Label titulo_libLabel1;
        private System.Windows.Forms.TextBox seccion_libTextBox;
        private System.Windows.Forms.Label autor_libLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bBuscarAutor;
        private System.Windows.Forms.Button bBuscarTitulo;
        private System.Windows.Forms.Button bBuscarID;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
