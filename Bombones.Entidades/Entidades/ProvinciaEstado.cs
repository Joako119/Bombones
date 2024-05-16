using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Entidades.Entidades
{
    public class ProvinciaEstado
	{
        public int ProvinciaEstadoId { get; set; }
        public string NombreProvinciaEstado { get; set; } = null!;
        public int PaisId { get; set; }
        public Pais? pais { get; set; }









    }
}
