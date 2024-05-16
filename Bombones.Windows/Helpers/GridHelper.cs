using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView grid) 
        {
            grid.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView grid) 
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj )
        {
            switch (obj)
            {
                case TipoDeChocolate tc:
                    r.Cells[0].Value = tc.Descripcion;
                    break;
                case TipoDeRelleno tr:
                    r.Cells[0].Value = tr.Descripcion;
                    break;
                case Pais p:
                    r.Cells[0].Value=p.NombrePais;
                    break;
                case Nuez n:
                    r.Cells[0].Value=n.Descripcion;
                    r.Cells[1].Value = n.Stock;
                    break;
                case ProvinciaEstadoListDto pe:
                    r.Cells[0].Value = pe.NombreProvinciaEstado;
                    r.Cells[1].Value = pe.NombrePais;
                    break;
                default:
                    break;
            } 
            r.Tag= obj;
          
        }

        public static void AgregarFila(DataGridViewRow r,DataGridView grid) 
        {
            grid.Rows.Add(r);
        }

        public static void QuitarFila(DataGridViewRow r,DataGridView grid)
        {
            grid.Rows.Remove(r);
        }












    }
}
