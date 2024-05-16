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
    public class ServicioNuez : IServicioNuez
    {
        private readonly RepositorioTipoNuez _repositorio;

        public ServicioNuez()
        {
            _repositorio = new RepositorioTipoNuez();

        }

        public List<Nuez> GetLista()
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

        public void Guardar(Nuez nuez)
        {
            try
            {
                if (nuez.NuezId == 0)
                {
                    _repositorio.Agregar(nuez);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(int NuezId)
        {
            try
            {
                _repositorio.Borrar(NuezId);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool EstaRelacionado(int NuezId)
        {
            try
            {
                return _repositorio.EstaRelacionado(NuezId);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Existe(Nuez nuez)
        {
            try
            {
                return _repositorio.Existe(nuez);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
