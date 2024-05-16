using Bombones.Datos.Interfaces;
using Bombones.Datos.Repositorios;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosTiposDeRellenos : IServiciosTiposDeRellenos
    {
        private readonly IRepositorioTiposDeRellenos _repositorio;
        public ServiciosTiposDeRellenos()
        {
            _repositorio = new RepositorioTiposDeRellenos();
        }

        public bool Existe(TipoDeRelleno tipoDeRelleno)
        {
            try
            {
                return _repositorio.Existe(tipoDeRelleno);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoDeRelleno> GetLista()
        {
            try
            {
                return _repositorio.GetLista();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Guardar(TipoDeRelleno tipoDeRelleno)
        {
            try
            {
                if (tipoDeRelleno.TipoDeRellenoId == 0)
                {
                    _repositorio.Agregar(tipoDeRelleno);
                }
                else
                {
                    _repositorio.Editar(tipoDeRelleno);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Borrar(int tipoDeRellenoId)
        {
            try
            {
                _repositorio.Borrar(tipoDeRellenoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(int tipoDeRellenoId)
        {
            try
            {
                return _repositorio.EstaRelacionado(tipoDeRellenoId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
