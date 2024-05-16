using Bombones.Datos.Interfaces;
using Bombones.Datos.Repositorios;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Servicios
{
    public class ServicioProvinciaEstado : IServiciosProvinciasEstados
    {
        private readonly IRepositorioProvinciaEstado _repositorioProvinciaEstado;
        public ServicioProvinciaEstado()
        {
            _repositorioProvinciaEstado=new RepositorioProvinciasEstados();
        }
        public List<ProvinciaEstadoListDto> GelLista()
        {
            try
            {
                return _repositorioProvinciaEstado.GetLista();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
