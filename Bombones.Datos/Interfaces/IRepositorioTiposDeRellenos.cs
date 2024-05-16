using Bombones.Entidades.Entidades;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioTiposDeRellenos
    {
        void Agregar(TipoDeRelleno tipoDeRelleno);
        void Borrar(int tipoDeRellenoId);
        void Editar(TipoDeRelleno tipoDeRelleno);
        bool EstaRelacionado(int tipoId);
        bool Existe(TipoDeRelleno tipoDeRelleno);
        List<TipoDeRelleno> GetLista();
    }
}