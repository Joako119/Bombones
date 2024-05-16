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
    public partial class frmTipoDeRelleno : Form
    {
        private readonly IServiciosTiposDeRellenos _servicio;
        private List<TipoDeRelleno> lista;
        public frmTipoDeRelleno()
        {
            InitializeComponent();
            _servicio = new ServiciosTiposDeRellenos();
        }

        private void frmTipoDeRelleno_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var tipo in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos1);
                GridHelper.SetearFila(r, tipo);
                GridHelper.AgregarFila(r, dgvDatos1);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDeRelleno tipo)
        {
            r.Cells[colTipoDeRelleno.Index].Value = tipo.Descripcion;

            r.Tag = tipo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmTiposDeRellenosAE frm = new frmTiposDeRellenosAE() { Text = "Agregar Relleno" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                ////TipoDeRelleno tipo = frm.GetRelleno();
                //if (!_servicio.Existe(tipo))
                //{
                //    _servicio.Guardar(tipo);
                //    DataGridViewRow r = ConstruirFila();
                //    SetearFila(r, tipo);
                //    AgregarFila(r);
                //    MessageBox.Show("Registro agregado",
                //        "Mensaje",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);

                //}
                //else
                //{
                //    MessageBox.Show("País Duplicado!!!",
                //        "Error",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);

                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {


            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            TipoDeRelleno tipo = (TipoDeRelleno)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el tipo {tipo.Descripcion}?",
                        "Confirmar Baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!_servicio.EstaRelacionado(tipo.TipoDeRellenoId))
                {
                    _servicio.Borrar(tipo.TipoDeRellenoId);
                    QuitarFila(r);
                    MessageBox.Show("Registro eliminado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro relacionado\nBaja Denegada",
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
            TipoDeRelleno tipo = (TipoDeRelleno)r.Tag;
            frmTiposDeRellenosAE frm = new frmTiposDeRellenosAE() { Text = "Editar Nuez" };
           // frm.SetRelleno(tipo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
           // tipo = frm.GetRelleno();
            try
            {
                if (!_servicio.Existe(tipo))
                {
                    _servicio.Guardar(tipo);

                    SetearFila(r, tipo);
                    MessageBox.Show("Registro modificado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("País Duplicado!!!",
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


    }
}





    