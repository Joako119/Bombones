using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioTipoDeChocolates : IRepositorioTipoDeChocolates
    {
        private readonly string _cadenaConexion;
        public RepositorioTipoDeChocolates()
        {
            _cadenaConexion = ConfigurationManager
                .ConnectionStrings["MiConexion"]
                .ToString();
        }

        public List<TipoDeChocolate> GetLista()
        {
            List<TipoDeChocolate> lista = new List<TipoDeChocolate>();
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string cadenaComando = @"SELECT TipoDeChocolateId,
                    Descripcion FROM TiposDeChocolates";
                using (var cmd = new SqlCommand(cadenaComando, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoDeChocolate tipo =
                                ConstruirTipo(reader);
                            lista.Add(tipo);
                        }
                    }
                }
                return lista;
            }
        }

        private TipoDeChocolate ConstruirTipo(SqlDataReader reader)
        {
            return new TipoDeChocolate
            {
                TipoDeChocolateId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public bool EstaRelacionado(int tipoId)
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT COUNT(*) FROM Bombones 
                    WHERE TipoDeChocolateId=@TipoDeChocolateId";
                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters
                            .AddWithValue("@TipoDeChocolateId", tipoId);

                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si está relacionado el tipo de Chocolate");
            }

        }
        public bool Existe(TipoDeChocolate tipoDeChocolate)
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT * FROM TiposDeChocolates ";
                    if (tipoDeChocolate.TipoDeChocolateId == 0)
                    {
                        string conditional = "WHERE Descripcion = @Descripcion";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        using (var cmd = new SqlCommand(finalQuery, conn))
                        {
                            cmd.Parameters
                                .AddWithValue("@Descripcion", tipoDeChocolate.Descripcion);

                            using (var reader = cmd.ExecuteReader())
                            {
                                return reader.HasRows;
                            }
                        }

                    }
                    else
                    {
                        string conditional = "WHERE Descripcion = @Descripcion AND TipoDeChocolateId<>@TipoDeChocolateId";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        using (var cmd = new SqlCommand(finalQuery, conn))
                        {
                            cmd.Parameters
                                .AddWithValue("@Descripcion", tipoDeChocolate.Descripcion);
                            cmd.Parameters
                                .AddWithValue("@TipoDeChocolateId", tipoDeChocolate.TipoDeChocolateId);

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

                throw new Exception("No se pudo comprobar si existe el tipo de chocolate");
            }
        }
        public void Agregar(TipoDeChocolate tipoDeChocolate)
        {
            int primaryKey = -1;
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO TiposDeChocolates (Descripcion) 
                    VALUES(@Descripcion); SELECT @@IDENTITY";
                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters
                        .AddWithValue("@Descripcion", tipoDeChocolate.Descripcion);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        primaryKey = Convert.ToInt32(result);
                        tipoDeChocolate.TipoDeChocolateId = primaryKey;
                    }
                    else
                    {
                        throw new Exception("No se pudo agregar el tipo de Chocolate");
                    }
                }
            }
        }

        public void Borrar(int tipoDeChocolateId)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string deleteQuery = @"DELETE FROM TiposDeChocolates 
                    WHERE TipoDeChocolateId=@TipoDeChocolateId";
                using (var cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters
                        .AddWithValue("@TipoDeChocolateId", tipoDeChocolateId);

                    int registrosAfectados = cmd.ExecuteNonQuery();
                    if (registrosAfectados == 0)
                    {
                        throw new Exception("No se pudo borrar el tipo de Chocolate");
                    }
                }
            }

        }

        public void Editar(TipoDeChocolate tipoDeChocolate)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string updateQuery = @"UPDATE TiposDeChocolates SET Descripcion=@Descripcion 
                    WHERE TipoDeChocolateId=@TipoDeChocolateId";
                using (var cmd = new SqlCommand(updateQuery, conn))
                {

                    cmd.Parameters
                        .AddWithValue("@Descripcion", tipoDeChocolate.Descripcion);
                    cmd.Parameters
                        .AddWithValue("@TipoDeChocolateId", tipoDeChocolate.TipoDeChocolateId);

                    int registrosAfectados = cmd.ExecuteNonQuery();
                    if (registrosAfectados == 0)
                    {
                        throw new Exception("No se pudo editar el tipo de Chocolate");
                    }
                }
            }


        }
    }
}
