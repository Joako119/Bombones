﻿namespace Bombones.Windows.Formularios
{
    partial class frmPaisesAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaisesAE));
            btnCancelar = new Button();
            btnOk = new Button();
            txtPais = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(550, 284);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 90);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(100, 284);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(413, 90);
            btnOk.TabIndex = 16;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(211, 77);
            txtPais.Margin = new Padding(4, 5, 4, 5);
            txtPais.MaxLength = 100;
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(487, 31);
            txtPais.TabIndex = 14;
            txtPais.TextChanged += txtPais_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 13;
            label1.Text = "País:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPaisesAE
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtPais);
            Controls.Add(label1);
            MaximumSize = new Size(822, 506);
            MinimumSize = new Size(822, 506);
            Name = "frmPaisesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPaisesAE";
            Load += frmPaisesAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtPais;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}