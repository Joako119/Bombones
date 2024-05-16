using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioProvinciasEstados : IRepositorioProvinciaEstado
    {
        private readonly string _cadenaConexion;
        public RepositorioProvinciasEstados()
        {
            _cadenaConexion = ConfigurationManager
                .ConnectionStrings["MiConexion"].ToString();
        }
        public List<ProvinciaEstadoListDto> GetLista()
        {
           using (var conn= new SqlConnection(_cadenaConexion))
            {
                var selectQuery = @"SELECT pe.ProvinciaEstadoId,
                   pe.NombreProvinciaEstado, p.NombrePais From ProvinciasEstados pe
                    INNER JOIN Paises p ON pe.PaisId=p.PaisId";
                return conn.Query<ProvinciaEstadoListDto>(selectQuery).ToList();
            }
        }
    }
}
