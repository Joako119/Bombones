using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Interfaces
{
    public interface IServicioNuez
    {
        void Borrar(int NuezId);
        bool EstaRelacionado(int NuezId);
        bool Existe(Nuez nuez);
        List<Nuez> GetLista();
        void Guardar(Nuez nuez);
    }
}