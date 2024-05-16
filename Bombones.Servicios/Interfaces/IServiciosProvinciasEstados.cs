using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Interfaces
{
    public interface IServiciosProvinciasEstados
    {
        List<ProvinciaEstadoListDto> GelLista();
    }
}
