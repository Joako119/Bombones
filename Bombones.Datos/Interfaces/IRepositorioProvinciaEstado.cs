using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioProvinciaEstado
    {
        List<ProvinciaEstadoListDto> GetLista();

    }
}
