using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Interfaces
{
    public interface IServiciosPaises
    {
        void Borrar(int paisID);
        bool EstaRelacionado(int paisID);
        bool Existe(Pais pais);
        List<Pais> GetLista();
        void Guardar(Pais pais);
    }
}