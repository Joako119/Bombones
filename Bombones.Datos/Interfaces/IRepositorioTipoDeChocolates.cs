using Bombones.Entidades.Entidades;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioTipoDeChocolates
    {
        void Agregar(TipoDeChocolate tipoDeChocolate);
        void Borrar(int tipoDeChocolateId);
        void Editar(TipoDeChocolate tipoDeChocolate);
        bool EstaRelacionado(int tipoId);
        bool Existe(TipoDeChocolate tipoDeChocolate);
        List<TipoDeChocolate> GetLista();
    }
}