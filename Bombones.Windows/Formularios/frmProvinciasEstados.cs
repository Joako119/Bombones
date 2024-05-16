using Bombones.Entidades.Dtos;
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
    public partial class frmProvinciasEstados : Form
    {
        private readonly IServiciosProvinciasEstados _servicio;
        private List<ProvinciaEstadoListDto> lista;
        public frmProvinciasEstados()
        {
            InitializeComponent();
            _servicio = new ServicioProvinciaEstado();
        }

        private void frmProvinciasEstados_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _servicio.GelLista();
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
            foreach (var item in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, item);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

    }
}
