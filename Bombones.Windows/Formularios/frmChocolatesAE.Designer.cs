namespace Bombones.Windows
{
    partial class frmChocolatesAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChocolatesAE));
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            txtChocolate = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Chocolate:";
            label1.Click += label1_Click;
            // 
            // txtChocolate
            // 
            txtChocolate.Location = new Point(146, 37);
            txtChocolate.Margin = new Padding(4, 5, 4, 5);
            txtChocolate.MaxLength = 50;
            txtChocolate.Name = "txtChocolate";
            txtChocolate.Size = new Size(487, 31);
            txtChocolate.TabIndex = 6;
         
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(34, 243);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(413, 90);
            btnOk.TabIndex = 8;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(484, 243);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 90);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmChocolatesAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 343);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtChocolate);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(703, 399);
            MinimumSize = new Size(703, 399);
            Name = "frmChocolatesAE";
            Text = "ChocolatesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtChocolate;
        private Label label1;
    }
}