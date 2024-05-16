using Bombones.Entidades.Entidades;
using Bombones.Servicios.Interfaces;
using Bombones.Servicios.Servicios;
using Bombones.Windows.Helpers;
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
    public partial class frmNuez : Form
    {
        private readonly IServicioNuez servicioNuez;

        private List<Nuez> lista;


        public frmNuez()
        {
            InitializeComponent();
            servicioNuez = new ServicioNuez();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmNuezAE frm = new frmNuezAE() { Text = "Agregar nuez" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Nuez nuez = frm.GetNuez();
                servicioNuez.Guardar(nuez);
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos1);
              GridHelper.SetearFila(r, nuez);
              GridHelper.AgregarFila(r, dgvDatos1);
                MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void frmNuez_Load(object sender, EventArgs e)
        {
            try
            {
                lista = servicioNuez.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos1);
            foreach (var chocolate in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos1);
                GridHelper.SetearFila(r, chocolate);
                GridHelper.AgregarFila(r, dgvDatos1);
            }
        }

     
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos1.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos1.SelectedRows[0];
            Nuez nuez = (Nuez)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($@"desea dar de baja el nuez {nuez.Descripcion}",
                    "confirmar baja", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!servicioNuez.EstaRelacionado(nuez.NuezId))
                {
                    servicioNuez.Borrar(nuez.NuezId);
                  GridHelper.QuitarFila(r,dgvDatos1);
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



        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos1.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos1.SelectedRows[0];
            Nuez nuez = (Nuez)r.Tag;
            frmNuezAE frm = new frmNuezAE() { Text = "Editar nuez" };
            frm.SetNuez(nuez);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {

                if (!servicioNuez.Existe(nuez))
                {
                    servicioNuez.Guardar(nuez);

                   GridHelper.SetearFila(r, nuez);

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
