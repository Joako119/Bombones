using Bombones.Windows.Formularios;

namespace Bombones.Windows
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void btnChocolates_Click(object sender, EventArgs e)
        {
            var frm = new frmChocolates();   // Crea frm, un objeto del tipo formulario frmChocolates
            frm.ShowDialog();       // muestra frm de forma modal
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            var frm = new frmPaises();
            frm.ShowDialog();
        }

        private void btnRellenos_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoDeRelleno();
            frm.ShowDialog();
        }

        private void btnNueces_Click(object sender, EventArgs e)
        {
            var frm = new frmNuez();
            frm.ShowDialog();
        }

        private void btnBombones_Click(object sender, EventArgs e)
        {

        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {

        }

        private void btnProvinciaEstado_Click(object sender, EventArgs e)
        {
            var frm = new frmProvinciasEstados();
            frm.ShowDialog();
        }
    }
}
