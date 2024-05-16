using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Dapper;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioPaises:IRepositorioPaises
    {
        private readonly string _cadenaConexion;
        public RepositorioPaises()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }

        public bool EstaRelacionado(int paisID) 
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                  
                    string selectQuery = "SELECT COUNT (*) FROM ProvinciasEstados WHERE PaisId=@PaisId";
                  return conn.QuerySingle<int>(selectQuery,new { paisID })>0;
                }
            }
            catch (Exception)
            {

                throw new Exception("No se pudos comprobar si existe");
            }
        }
        public bool Existe(Pais pais) 
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT COUNT (*) FROM Paises ";
                    if (pais.PaisId == 0)
                    {
                        string conditional = "WHERE NombrePais = @Nombre";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        return conn.QuerySingle<int>(finalQuery,pais)> 0;

                    }
                    else
                    {
                        string conditional = "WHERE NombrePais = @Nombre AND PaisId<>@PaisId";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        return conn.QuerySingle<int>(finalQuery, pais) > 0;
                    }
                }

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si existe el país");
            }


        }
        public List<Pais> GetLista()
        {
            List<Pais> lista = new List<Pais>();
            using (var conn = new SqlConnection(_cadenaConexion))
            {
               
                var selectQuery = @"SELECT PaisId, NombrePais FROM 
                    Paises ORDER BY NombrePais";
                     return conn.Query<Pais>(selectQuery).ToList();
            }

        }

      
        public void Borrar(int paisID)
        {


            using (var conn = new SqlConnection(_cadenaConexion))
            {
              
                string deleteQuery = "DELETE FROM Paises WHERE PaisID= @PaisID ";
         
                    int registrosAfectados = conn.Execute(deleteQuery, new { paisID});
                    if (registrosAfectados==0)
                    {
                        throw new Exception("No se pudo borrar el pais");
                    }
                
            }


        }




    

        public void Agregar(Pais pais)
        {
            int primaryKeey = -1;
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Paises (NombrePais) VALUES (@Nombre); SELECT @@IDENTITY";
                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", pais.NombrePais);

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        primaryKeey = Convert.ToInt32(result);
                        pais.PaisId = primaryKeey;
                    }
                    else
                    {
                        throw new Exception("No se pudo agregar el pais");
                    }
                }
            }


        }

        public void Editar(Pais pais)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string updateQuery = @"UPDATE Paises SET NombrePais=@Nombre
                   WHERE PaisId=@PaisId   ";
                using (var cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", pais.NombrePais);
                    cmd.Parameters.AddWithValue("@PaisId", pais.PaisId);

                   int registrosAfectados=cmd.ExecuteNonQuery();
                    if (registrosAfectados==0)
                    {
                        throw new Exception("No se pudo editar el pais");
                    }
                }
            }
        }
    } 
}