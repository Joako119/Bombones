using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Interfaces
{
    internal interface IRepositorioPaises
    {
        void Agregar(Pais pais);
        void Borrar(int pais);
        void Editar(Pais pais);
        bool EstaRelacionado(int tipoId);
        bool Existe(Pais pais);
        List<Pais> GetLista();
    }
}
