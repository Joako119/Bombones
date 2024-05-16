using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Interfaces;
using Bombones.Servicios.Servicios;
using Bombones.Windows.Helpers;
namespace Bombones.Windows.Formularios
{
    public partial class frmPaises : Form
    {

        private readonly IServiciosPaises servicio;
        private List<Pais> lista;
        public frmPaises()
        {
            InitializeComponent();
            servicio = new ServiciosPaises();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPaisesAE frm = new frmPaisesAE() { Text = "Agregar País" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Pais pais = frm.GetPais();

                if (!servicio.Existe(pais))
                {
                    servicio.Guardar(pais);
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, pais);
                   GridHelper.AgregarFila(r,dgvDatos);
                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("País Duplicado",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }


        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var chocolate in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, chocolate);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }



        private void frmPaises_Load_1(object sender, EventArgs e)
        {
            try
            {
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Pais pais = (Pais)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($@"desea dar de baja el pais {pais.NombrePais}",
                    "confirmar baja", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!servicio.EstaRelacionado(pais.PaisId))
                {
                    servicio.Borrar(pais.PaisId);
                    QuitarFila(r);
                    MessageBox.Show("Registro eliminado",
                      "Mensaje",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro relacionado\nBaja denegada",
                      "Mensaje",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }

        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Pais pais = (Pais)r.Tag;
            frmPaisesAE frm = new frmPaisesAE() { Text = "Editar pais" };
            frm.SetPais(pais);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {

                if (!servicio.Existe(pais))
                {
                    servicio.Guardar(pais);

                   GridHelper.SetearFila(r, pais);

                    MessageBox.Show("Registro Modificado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("País Duplicado",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }


        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


