using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Interfaces
{
    public interface IServiciosTiposDeChocolates
    {
        void Borrar(int tipoDeChocolateId);
        bool Existe(TipoDeChocolate tipoDeChocolate);
        List<TipoDeChocolate> GetLista();
        void Guardar(TipoDeChocolate tipoDeChocolate);
    }
}