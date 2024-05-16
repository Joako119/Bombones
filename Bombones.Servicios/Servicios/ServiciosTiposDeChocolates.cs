using Bombones.Datos.Interfaces;
using Bombones.Datos.Repositorios;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Interfaces;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosTiposDeChocolates : IServiciosTiposDeChocolates
    {
        //private readonly RepositorioSecuencialTiposDeChocolates _repositorio;
        private readonly IRepositorioTipoDeChocolates _repositorio;
        public ServiciosTiposDeChocolates()
        {
            _repositorio = new RepositorioTipoDeChocolates();



        }

        public bool Existe(TipoDeChocolate tipoDeChocolate)
        {
            try
            {
                return _repositorio.Existe(tipoDeChocolate);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoDeChocolate> GetLista()
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

        public void Borrar(int tipoDeChocolateId)
        {
            try
            {
                _repositorio.Borrar(tipoDeChocolateId);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public void Guardar(TipoDeChocolate tipoDeChocolate)
        {
            try
            {
                if (tipoDeChocolate.TipoDeChocolateId == 0)
                {
                    _repositorio.Agregar(tipoDeChocolate);
                }
                else
                {
                    _repositorio.Editar(tipoDeChocolate);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
