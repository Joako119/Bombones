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
    public class ServiciosPaises : IServiciosPaises
    {
        private readonly RepositorioPaises _repositorio;

        public ServiciosPaises()
        {
            _repositorio = new RepositorioPaises();

        }


        public List<Pais> GetLista()
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

        public void Guardar(Pais pais)
        {
            try
            {
                if (pais.PaisId == 0)
                {
                    _repositorio.Agregar(pais);
                }
                else
                {
                    _repositorio.Editar(pais);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Borrar(int paisID)
        {
            try
            {
                _repositorio.Borrar(paisID);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool EstaRelacionado(int paisID)
        {
            try
            {
                return _repositorio.EstaRelacionado(paisID);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Existe(Pais pais)
        {
            try
            {
                return _repositorio.Existe(pais);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
