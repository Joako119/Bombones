using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones.Windows.Formularios
{
    public partial class frmPaisesAE : Form
    {

        public Pais pais;
        public frmPaisesAE()
        {
            InitializeComponent();
        }
        public Pais GetPais()
        {
            return pais;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais == null)
                {
                    pais = new Pais();
                }
                pais.NombrePais = txtPais.Text;

                DialogResult = DialogResult.OK;
            }
        }


        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                valido = false;
                errorProvider1.SetError(txtPais, "El país es requerido");
            }
            return valido;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais != null)
            {
                txtPais.Text = pais.NombrePais;
            }
        }
        public void SetPais(Pais? pais)
        {
            this.pais = pais;
        }

        private void frmPaisesAE_Load(object sender, EventArgs e)
        {

        }

       
    }
}
