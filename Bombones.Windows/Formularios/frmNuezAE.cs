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
    public partial class frmNuezAE : Form
    {
        private Nuez nuez;
        public frmNuezAE()
        {
            InitializeComponent();
        }

        public Nuez GetNuez()
        {
            return nuez;
        }

        private void frmNuezAE_Load(object sender, EventArgs e)
        {

        }

        private void txtChocolate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (nuez == null)
                {
                    nuez = new Nuez();
                }
                nuez.Descripcion =txtDescripcion.Text;
                nuez.Stock=int.Parse(txtStock.Text);//me encargo yo de castear, puede fallar

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "La descripcion es requerida");
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                valido = false;
                errorProvider2.SetError(txtStock, "El strock debe ser agregado aunque sea un 0");
            }
            return valido;
        }

     
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (nuez != null)
            {
                txtDescripcion.Text = nuez.Descripcion;
              //txtStock.Text= int.Parse(nuez.Stock);
            }
        }
      
        internal void SetNuez(Nuez? nuez)
        {
             this.nuez = nuez;
        }

       
    }
}
