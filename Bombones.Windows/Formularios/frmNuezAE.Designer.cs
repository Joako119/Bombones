namespace Bombones.Windows.Formularios
{
    partial class frmNuezAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuezAE));
            label1 = new Label();
            btnCancelar = new Button();
            btnOk = new Button();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 89);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 23;
            label1.Text = "nuez:";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(535, 292);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(267, 90);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(31, 292);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(413, 90);
            btnOk.TabIndex = 22;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(181, 86);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(587, 31);
            txtDescripcion.TabIndex = 20;
            txtDescripcion.TextChanged += txtChocolate_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 213);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 25;
            label2.Text = "stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(166, 210);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.MaxLength = 50;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(587, 31);
            txtStock.TabIndex = 24;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // frmNuezAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtDescripcion);
            Name = "frmNuezAE";
            Text = "frmNuezAE";
            Load += frmNuezAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtStock;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}