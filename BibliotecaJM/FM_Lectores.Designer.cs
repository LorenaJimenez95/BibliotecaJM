namespace BibliotecaJM
{
    partial class FM_Lectores
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
            System.Windows.Forms.Label provincia_lecLabel;
            System.Windows.Forms.Label email_lecLabel;
            System.Windows.Forms.Label fecha_nacimiento_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bProvincias = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.gbBuscarLector = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.provincia_lecTextBox = new System.Windows.Forms.TextBox();
            this.email_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            email_lecLabel = new System.Windows.Forms.Label();
            fecha_nacimiento_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.gbBuscarLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(id_lecLabel);
            this.groupBox2.Controls.Add(this.id_lecTextBox);
            this.groupBox2.Controls.Add(nombre_lecLabel);
            this.groupBox2.Controls.Add(this.nombre_lecTextBox);
            this.groupBox2.Controls.Add(domicilio_lecLabel);
            this.groupBox2.Controls.Add(this.domicilio_lecTextBox);
            this.groupBox2.Controls.Add(provincia_lecLabel);
            this.groupBox2.Controls.Add(this.provincia_lecTextBox);
            this.groupBox2.Controls.Add(email_lecLabel);
            this.groupBox2.Controls.Add(this.email_lecTextBox);
            this.groupBox2.Controls.Add(fecha_nacimiento_lecLabel);
            this.groupBox2.Controls.Add(this.fecha_nacimiento_lecDateTimePicker);
            this.groupBox2.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox2.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.groupBox2.Controls.Add(this.bProvincias);
            this.groupBox2.Controls.Add(this.bCancelar);
            this.groupBox2.Controls.Add(this.bAceptar);
            this.groupBox2.Location = new System.Drawing.Point(530, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 520);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficha Lector";
            // 
            // bProvincias
            // 
            this.bProvincias.Location = new System.Drawing.Point(362, 142);
            this.bProvincias.Name = "bProvincias";
            this.bProvincias.Size = new System.Drawing.Size(32, 23);
            this.bProvincias.TabIndex = 16;
            this.bProvincias.Text = "...";
            this.bProvincias.UseVisualStyleBackColor = true;
            this.bProvincias.Click += new System.EventHandler(this.bProvincias_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(301, 469);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 15;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(165, 470);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // gbBuscarLector
            // 
            this.gbBuscarLector.Controls.Add(this.lectoresDataGridView);
            this.gbBuscarLector.Controls.Add(this.bEliminar);
            this.gbBuscarLector.Controls.Add(this.bModificar);
            this.gbBuscarLector.Controls.Add(this.bNuevo);
            this.gbBuscarLector.Controls.Add(this.bBuscarNombre);
            this.gbBuscarLector.Controls.Add(this.bBuscarId);
            this.gbBuscarLector.Controls.Add(this.textBox2);
            this.gbBuscarLector.Controls.Add(this.textBox1);
            this.gbBuscarLector.Controls.Add(this.label2);
            this.gbBuscarLector.Controls.Add(this.label1);
            this.gbBuscarLector.Location = new System.Drawing.Point(12, 90);
            this.gbBuscarLector.Name = "gbBuscarLector";
            this.gbBuscarLector.Size = new System.Drawing.Size(457, 527);
            this.gbBuscarLector.TabIndex = 2;
            this.gbBuscarLector.TabStop = false;
            this.gbBuscarLector.Text = "Buscar Lector";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(313, 483);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 9;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(177, 484);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 8;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(37, 484);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 7;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(313, 67);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 6;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(313, 28);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 5;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            this.bBuscarId.Click += new System.EventHandler(this.bBuscarId_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(6, 142);
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.Size = new System.Drawing.Size(436, 220);
            this.lectoresDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_lec";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_lec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "domicilio_lec";
            this.dataGridViewTextBoxColumn3.HeaderText = "domicilio_lec";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "provincia_lec";
            this.dataGridViewTextBoxColumn4.HeaderText = "provincia_lec";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email_lec";
            this.dataGridViewTextBoxColumn5.HeaderText = "email_lec";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_nacimiento_lec";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha_nacimiento_lec";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_penalizacion_lec";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_penalizacion_lec";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(33, 67);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(35, 13);
            id_lecLabel.TabIndex = 16;
            id_lecLabel.Text = "id lec:";
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(155, 64);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_lecTextBox.TabIndex = 17;
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(33, 93);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(62, 13);
            nombre_lecLabel.TabIndex = 18;
            nombre_lecLabel.Text = "nombre lec:";
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(155, 90);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 19;
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(33, 119);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(67, 13);
            domicilio_lecLabel.TabIndex = 20;
            domicilio_lecLabel.Text = "domicilio lec:";
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(155, 116);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 21;
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Location = new System.Drawing.Point(33, 145);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(70, 13);
            provincia_lecLabel.TabIndex = 22;
            provincia_lecLabel.Text = "provincia lec:";
            // 
            // provincia_lecTextBox
            // 
            this.provincia_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "provincia_lec", true));
            this.provincia_lecTextBox.Location = new System.Drawing.Point(155, 142);
            this.provincia_lecTextBox.Name = "provincia_lecTextBox";
            this.provincia_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.provincia_lecTextBox.TabIndex = 23;
            // 
            // email_lecLabel
            // 
            email_lecLabel.AutoSize = true;
            email_lecLabel.Location = new System.Drawing.Point(33, 171);
            email_lecLabel.Name = "email_lecLabel";
            email_lecLabel.Size = new System.Drawing.Size(51, 13);
            email_lecLabel.TabIndex = 24;
            email_lecLabel.Text = "email lec:";
            // 
            // email_lecTextBox
            // 
            this.email_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "email_lec", true));
            this.email_lecTextBox.Location = new System.Drawing.Point(155, 168);
            this.email_lecTextBox.Name = "email_lecTextBox";
            this.email_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.email_lecTextBox.TabIndex = 25;
            // 
            // fecha_nacimiento_lecLabel
            // 
            fecha_nacimiento_lecLabel.AutoSize = true;
            fecha_nacimiento_lecLabel.Location = new System.Drawing.Point(33, 198);
            fecha_nacimiento_lecLabel.Name = "fecha_nacimiento_lecLabel";
            fecha_nacimiento_lecLabel.Size = new System.Drawing.Size(108, 13);
            fecha_nacimiento_lecLabel.TabIndex = 26;
            fecha_nacimiento_lecLabel.Text = "fecha nacimiento lec:";
            // 
            // fecha_nacimiento_lecDateTimePicker
            // 
            this.fecha_nacimiento_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_nacimiento_lecDateTimePicker.Location = new System.Drawing.Point(155, 194);
            this.fecha_nacimiento_lecDateTimePicker.Name = "fecha_nacimiento_lecDateTimePicker";
            this.fecha_nacimiento_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_nacimiento_lecDateTimePicker.TabIndex = 27;
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(33, 224);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(116, 13);
            fecha_penalizacion_lecLabel.TabIndex = 28;
            fecha_penalizacion_lecLabel.Text = "fecha penalizacion lec:";
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(155, 220);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 29;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbBuscarLector);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBuscarLector.ResumeLayout(false);
            this.gbBuscarLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bProvincias;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox gbBuscarLector;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.TextBox provincia_lecTextBox;
        private System.Windows.Forms.TextBox email_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento_lecDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
