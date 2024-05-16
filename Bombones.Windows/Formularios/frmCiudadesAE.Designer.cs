namespace Bombones.Windows.Formularios
{
    partial class frmCiudadesAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudadesAE));
            label3 = new Label();
            cboProvinciasEstados = new ComboBox();
            cboPaises = new ComboBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnOk = new Button();
            txtChocolate = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 29;
            label3.Text = "Ciudad:";
            // 
            // cboProvinciasEstados
            // 
            cboProvinciasEstados.FormattingEnabled = true;
            cboProvinciasEstados.Location = new Point(181, 140);
            cboProvinciasEstados.Margin = new Padding(4, 5, 4, 5);
            cboProvinciasEstados.Name = "cboProvinciasEstados";
            cboProvinciasEstados.Size = new Size(448, 33);
            cboProvinciasEstados.TabIndex = 27;
            // 
            // cboPaises
            // 
            cboPaises.FormattingEnabled = true;
            cboPaises.Location = new Point(181, 202);
            cboPaises.Margin = new Padding(4, 5, 4, 5);
            cboPaises.Name = "cboPaises";
            cboPaises.Size = new Size(448, 33);
            cboPaises.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 26;
            label2.Text = "País:";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(619, 285);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 90);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(31, 285);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(413, 90);
            btnOk.TabIndex = 25;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtChocolate
            // 
            txtChocolate.Location = new Point(181, 75);
            txtChocolate.Margin = new Padding(4, 5, 4, 5);
            txtChocolate.MaxLength = 50;
            txtChocolate.Name = "txtChocolate";
            txtChocolate.Size = new Size(587, 31);
            txtChocolate.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 22;
            label1.Text = "Provincia/Estado:";
            // 
            // frmCiudadesAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cboProvinciasEstados);
            Controls.Add(cboPaises);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtChocolate);
            Controls.Add(label1);
            Name = "frmCiudadesAE";
            Text = "frmCiudadesAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cboProvinciasEstados;
        private ComboBox cboPaises;
        private Label label2;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtChocolate;
        private Label label1;
    }
}