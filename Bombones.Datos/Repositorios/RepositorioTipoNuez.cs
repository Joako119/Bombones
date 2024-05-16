using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioTipoNuez : IRepositorioTipoNuez
    {
        private readonly string _cadenaConexion;

        public RepositorioTipoNuez()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }

        public List<Nuez> GetLista()
        {
            List<Nuez> lista = new List<Nuez>();
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                var insertQuery = @"SELECT TipoDeNuezId,Descripcion,Stock
                                    FROM TiposDeNueces ORDER BY Descripcion";

                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nuez nuez = ConstruirNuez(reader);
                            lista.Add(nuez);
                        }
                    }
                }
            }

            return lista;
        }
        public void Agregar(Nuez nuez)
        {
            int primaryKey = -1;
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO TiposDeNueces (Descripcion, Stock)
                                VALUES (@Descripcion, @Stock);
                            SELECT @@IDENTITY    ";

                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", nuez.Descripcion);
                    cmd.Parameters.AddWithValue("@Stock", nuez.Stock);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        primaryKey = Convert.ToInt32(result);
                        nuez.NuezId = primaryKey;
                    }
                    else
                    {
                        throw new Exception("No se pudo agregar la nuez");
                    }
                }
            }
        }
        private Nuez ConstruirNuez(SqlDataReader reader)
        {
            return new Nuez
            {
                NuezId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                Stock = reader.GetInt32(2)
            };
        }


        public void Borrar(int NuezId)
        {


            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM TiposDeNueces WHERE TipoDeNUezID= @TipoDeNuezID ";
                using (var cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TiuoDeNuezId", NuezId);

                    int registrosAfectados = cmd.ExecuteNonQuery();
                    if (registrosAfectados == 0)
                    {
                        throw new Exception("No se pudo borrar el tipo de nuez");
                    }
                }
            }


        }

        public bool EstaRelacionado(int TipoDeNuezId)
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT (*) FROM TiposDeNueces WHERE TipoDeNuezId=@TipoDeNuezId";
                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TipoDeNuezId", TipoDeNuezId);

                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("No se pudos comprobar si existe");
            }
        }
        public bool Existe(Nuez nuez)
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT * FROM TiposDeNueces ";
                    if (nuez.NuezId == 0)
                    {
                        string conditional = "WHERE Descripcion = @Descripcion";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        using (var cmd = new SqlCommand(finalQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Descripcion", nuez.Descripcion);


                            using (var reader = cmd.ExecuteReader())
                            {
                                return reader.HasRows;
                            }
                        }

                    }
                    else
                    {
                        string conditional = "WHERE Descripcion = @Descripcion AND NuezId <> @TiposDeNuezId";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        using (var cmd = new SqlCommand(finalQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", nuez.Descripcion);

                            cmd.Parameters.AddWithValue("@PaisId", nuez.NuezId);


                            using (var reader = cmd.ExecuteReader())
                            {
                                return reader.HasRows;
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si la nuez existe");
            }


        }

        public void Editar(Nuez nuez)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string updateQuery = @"UPDATE TiposDeNueces SET Descripcion=@Descripcion, Stock=@Stock
                   WHERE TipoDeNuezId=@NuezId   ";
                using (var cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", nuez.Descripcion);
                    cmd.Parameters.AddWithValue("@NuezId", nuez.NuezId);

                    int registrosAfectados = cmd.ExecuteNonQuery();
                    if (registrosAfectados == 0)
                    {
                        throw new Exception("No se pudo editar el tipo de nuez ");
                    }
                }
            }
        }
    }
}