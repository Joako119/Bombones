using Bombones.Entidades.Entidades;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioTipoNuez
    {
        void Agregar(Nuez nuez);
        void Borrar(int NuezId);
        void Editar(Nuez nuez);
        bool EstaRelacionado(int TipoDeNuezId);
        bool Existe(Nuez nuez);
        List<Nuez> GetLista();
    }
}