namespace BibliotecaJM
{
    partial class Seccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager();
            this.dS_Secciones = new BibliotecaJM.DS_Secciones();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seccionesTableAdapter = new BibliotecaJM.DS_SeccionesTableAdapters.seccionesTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_SeccionesTableAdapters.TableAdapterManager();
            this.seccionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Secciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_Provincias
            // 
            this.dS_Provincias.DataSetName = "DS_Provincias";
            this.dS_Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.dS_Provincias;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.provinciasTableAdapter = this.provinciasTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_Secciones
            // 
            this.dS_Secciones.DataSetName = "DS_Secciones";
            this.dS_Secciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seccionesBindingSource
            // 
            this.seccionesBindingSource.DataMember = "secciones";
            this.seccionesBindingSource.DataSource = this.dS_Secciones;
            // 
            // seccionesTableAdapter
            // 
            this.seccionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.seccionesTableAdapter = this.seccionesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_SeccionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // seccionesDataGridView
            // 
            this.seccionesDataGridView.AutoGenerateColumns = false;
            this.seccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seccionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.seccionesDataGridView.DataSource = this.seccionesBindingSource;
            this.seccionesDataGridView.Location = new System.Drawing.Point(24, 12);
            this.seccionesDataGridView.Name = "seccionesDataGridView";
            this.seccionesDataGridView.Size = new System.Drawing.Size(300, 426);
            this.seccionesDataGridView.TabIndex = 0;
            this.seccionesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seccionesDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sec";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_sec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "seccion_sec";
            this.dataGridViewTextBoxColumn2.HeaderText = "seccion_sec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Seccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.seccionesDataGridView);
            this.Name = "Seccion";
            this.Text = "Seccion";
            this.Load += new System.EventHandler(this.Seccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Secciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Provincias dS_Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private DS_ProvinciasTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_Secciones dS_Secciones;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private DS_SeccionesTableAdapters.seccionesTableAdapter seccionesTableAdapter;
        private DS_SeccionesTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView seccionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}