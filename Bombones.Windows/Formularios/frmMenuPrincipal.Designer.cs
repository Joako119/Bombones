namespace Bombones.Windows
{
    partial class frmMenuPrincipal
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
            btnRellenos = new Button();
            btnChocolates = new Button();
            btnNueces = new Button();
            btnPaises = new Button();
            btnFabricas = new Button();
            btnBombones = new Button();
            btnProvinciaEstado = new Button();
            btnCiudades = new Button();
            SuspendLayout();
            // 
            // btnRellenos
            // 
            btnRellenos.Location = new Point(34, 40);
            btnRellenos.Margin = new Padding(4, 5, 4, 5);
            btnRellenos.Name = "btnRellenos";
            btnRellenos.Size = new Size(199, 205);
            btnRellenos.TabIndex = 0;
            btnRellenos.Text = "Tipos de Relleno";
            btnRellenos.UseVisualStyleBackColor = true;
            btnRellenos.Click += btnRellenos_Click;
            // 
            // btnChocolates
            // 
            btnChocolates.Location = new Point(293, 40);
            btnChocolates.Margin = new Padding(4, 5, 4, 5);
            btnChocolates.Name = "btnChocolates";
            btnChocolates.Size = new Size(199, 205);
            btnChocolates.TabIndex = 0;
            btnChocolates.Text = "Tipos de Chocolate";
            btnChocolates.UseVisualStyleBackColor = true;
            btnChocolates.Click += btnChocolates_Click;
            // 
            // btnNueces
            // 
            btnNueces.Location = new Point(571, 40);
            btnNueces.Margin = new Padding(4, 5, 4, 5);
            btnNueces.Name = "btnNueces";
            btnNueces.Size = new Size(199, 205);
            btnNueces.TabIndex = 0;
            btnNueces.Text = "Tipos De Nuez";
            btnNueces.UseVisualStyleBackColor = true;
            btnNueces.Click += btnNueces_Click;
            // 
            // btnPaises
            // 
            btnPaises.Location = new Point(869, 40);
            btnPaises.Margin = new Padding(4, 5, 4, 5);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(199, 205);
            btnPaises.TabIndex = 0;
            btnPaises.Text = "Países";
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnFabricas
            // 
            btnFabricas.Location = new Point(34, 323);
            btnFabricas.Margin = new Padding(4, 5, 4, 5);
            btnFabricas.Name = "btnFabricas";
            btnFabricas.Size = new Size(199, 205);
            btnFabricas.TabIndex = 0;
            btnFabricas.Text = "Fábricas";
            btnFabricas.UseVisualStyleBackColor = true;
            // 
            // btnBombones
            // 
            btnBombones.Location = new Point(293, 323);
            btnBombones.Margin = new Padding(4, 5, 4, 5);
            btnBombones.Name = "btnBombones";
            btnBombones.Size = new Size(199, 205);
            btnBombones.TabIndex = 0;
            btnBombones.Text = "Bombones";
            btnBombones.UseVisualStyleBackColor = true;
            btnBombones.Click += btnBombones_Click;
            // 
            // btnProvinciaEstado
            // 
            btnProvinciaEstado.Location = new Point(571, 323);
            btnProvinciaEstado.Margin = new Padding(4, 5, 4, 5);
            btnProvinciaEstado.Name = "btnProvinciaEstado";
            btnProvinciaEstado.Size = new Size(199, 205);
            btnProvinciaEstado.TabIndex = 1;
            btnProvinciaEstado.Text = "Provincia/Estado";
            btnProvinciaEstado.UseVisualStyleBackColor = true;
            btnProvinciaEstado.Click += btnProvinciaEstado_Click;
            // 
            // btnCiudades
            // 
            btnCiudades.Location = new Point(869, 323);
            btnCiudades.Margin = new Padding(4, 5, 4, 5);
            btnCiudades.Name = "btnCiudades";
            btnCiudades.Size = new Size(199, 205);
            btnCiudades.TabIndex = 2;
            btnCiudades.Text = "Ciudades";
            btnCiudades.UseVisualStyleBackColor = true;
            btnCiudades.Click += btnCiudades_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnCiudades);
            Controls.Add(btnProvinciaEstado);
            Controls.Add(btnBombones);
            Controls.Add(btnFabricas);
            Controls.Add(btnPaises);
            Controls.Add(btnNueces);
            Controls.Add(btnChocolates);
            Controls.Add(btnRellenos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRellenos;
        private Button btnChocolates;
        private Button btnNueces;
        private Button btnPaises;
        private Button btnFabricas;
        private Button btnBombones;
        private Button btnProvinciaEstado;
        private Button btnCiudades;
    }
}