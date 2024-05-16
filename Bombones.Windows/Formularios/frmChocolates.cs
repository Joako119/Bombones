using Bombones.Datos.Repositorios;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Interfaces;
using Bombones.Servicios.Servicios;
using Bombones.Windows.Helpers;

namespace Bombones.Windows
{
    public partial class frmChocolates : Form
    {
        private List<TipoDeChocolate> lista=null!;
        private readonly IServiciosTiposDeChocolates _servicios;
       
      //  public ServiciosTiposDeChocolates() { _servicios = new RepositorioTipoDeChocolates(); }
        public frmChocolates()
        {
            InitializeComponent();
            _servicios = new ServiciosTiposDeChocolates();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChocolates_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _servicios.GetLista();      // la lista guarda el listado de los registros con los tipos de chocolate
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
            foreach (var chocolate in lista)      
            {
                var r =GridHelper.ConstruirFila(dgvDatos);       
                GridHelper.SetearFila(r, chocolate);         
                GridHelper.AgregarFila(r,dgvDatos);
            }
        }

      
    
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmChocolatesAE frm = new frmChocolatesAE() { Text = "Nuevo chocolate" };
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                TipoDeChocolate tipoDeChocolate = frm.GetTipo();

                if (!_servicios.Existe(tipoDeChocolate))
                {
                    _servicios.Guardar(tipoDeChocolate);
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, tipoDeChocolate);
                    GridHelper.AgregarFila(r,dgvDatos);
                    MessageBox.Show("Registro agregado",
                                    "Mensaje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nAlta denegada",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
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

            TipoDeChocolate tipoChocolate=null!;
            if (r.Tag != null)
            {
                tipoChocolate = (TipoDeChocolate)r.Tag;

            }
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al chocolate {tipoChocolate.Descripcion}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No)
                {
                    return;     

                }


                _servicios.Borrar(tipoChocolate.TipoDeChocolateId);

                GridHelper.QuitarFila(r, dgvDatos);
                MessageBox.Show("Registro eliminado satisfactoriamente",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            if (dgvDatos.SelectedRows.Count == 0)   // Si no hay filas seleccionadas, salgo
            {
                return;
            }
            try
            {
                var r = dgvDatos.SelectedRows[0];
                TipoDeChocolate tipoChocolate;
                if (r.Tag != null)
                {
                    tipoChocolate = (TipoDeChocolate)r.Tag;
                    frmChocolatesAE frm = new frmChocolatesAE { Text = "Editar chocolate" };
                    frm.SetTipo(tipoChocolate);
                    DialogResult dr = frm.ShowDialog(this);

                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    tipoChocolate = frm.GetTipo();

                    if (!_servicios.Existe(tipoChocolate))       // Si no existe el chocolate, lo edita
                    {
                        // Servicios ordena a Datos que guarde la edición en la BASE DE DATOS
                        _servicios.Guardar(tipoChocolate);
                        GridHelper.SetearFila(r, tipoChocolate);    // Agrega los datos en las celdas de una la fila que YA ESTÁ CREADA.
                        MessageBox.Show("Chocolate editado satisfactoriamente",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro existente\nEdicion denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception)
            {

            }
        }

    }
}
