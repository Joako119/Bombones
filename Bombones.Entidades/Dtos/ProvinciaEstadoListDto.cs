using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Entidades.Dtos
{
    public class ProvinciaEstadoListDto// dto es data transfer objet
    {
        public int ProvinciaEstadoId { get; set; }
        public string NombreProvinciaEstado { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
      

    }
}
