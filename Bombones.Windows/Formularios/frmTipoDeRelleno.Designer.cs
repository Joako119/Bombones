namespace Bombones.Windows.Formularios
{
    partial class frmTipoDeRelleno
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDeRelleno));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvDatos1 = new DataGridView();
            colTipoDeRelleno = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbImprimir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            dgvDatos = new DataGridView();
            colPais = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos1
            // 
            dgvDatos1.AllowUserToAddRows = false;
            dgvDatos1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos1.Columns.AddRange(new DataGridViewColumn[] { colTipoDeRelleno });
            dgvDatos1.Dock = DockStyle.Fill;
            dgvDatos1.Location = new Point(0, 74);
            dgvDatos1.Margin = new Padding(4, 5, 4, 5);
            dgvDatos1.MultiSelect = false;
            dgvDatos1.Name = "dgvDatos1";
            dgvDatos1.ReadOnly = true;
            dgvDatos1.RowHeadersVisible = false;
            dgvDatos1.RowHeadersWidth = 62;
            dgvDatos1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos1.Size = new Size(800, 376);
            dgvDatos1.TabIndex = 14;
            // 
            // colTipoDeRelleno
            // 
            colTipoDeRelleno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoDeRelleno.HeaderText = "TipoDeRelleno";
            colTipoDeRelleno.MinimumWidth = 8;
            colTipoDeRelleno.Name = "colTipoDeRelleno";
            colTipoDeRelleno.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbImprimir, toolStripSeparator3, tsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(800, 74);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(68, 69);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(64, 69);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(61, 69);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 74);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(60, 69);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(92, 69);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 74);
            // 
            // tsbImprimir
            // 
            tsbImprimir.Image = (Image)resources.GetObject("tsbImprimir.Image");
            tsbImprimir.ImageScaling = ToolStripItemImageScaling.None;
            tsbImprimir.ImageTransparentColor = Color.Magenta;
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(84, 69);
            tsbImprimir.Text = "Imprimir";
            tsbImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 74);
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(63, 69);
            tsbCerrar.Text = "Cerrar";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colPais });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(4, 5, 4, 5);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 450);
            dgvDatos.TabIndex = 12;
            // 
            // colPais
            // 
            colPais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPais.HeaderText = "País";
            colPais.MinimumWidth = 8;
            colPais.Name = "colPais";
            colPais.ReadOnly = true;
            // 
            // frmTipoDeRelleno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos1);
            Controls.Add(toolStrip1);
            Controls.Add(dgvDatos);
            Name = "frmTipoDeRelleno";
            Text = "frmTipoDeRelleno";
            Load += frmTipoDeRelleno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos1;
        private DataGridViewTextBoxColumn colTipoDeRelleno;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbImprimir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbCerrar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colPais;
    }
}