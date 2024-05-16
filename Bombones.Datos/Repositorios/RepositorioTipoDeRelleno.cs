
using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using System.Configuration;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioTiposDeRellenos : IRepositorioTiposDeRellenos
    {
        private readonly string _cadenaConexion;
        public RepositorioTiposDeRellenos()
        {
            _cadenaConexion = ConfigurationManager
                .ConnectionStrings["MiConexion"].ToString();
        }
        public bool EstaRelacionado(int tipoId)
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT COUNT(*) FROM Bombones 
                    WHERE TipoDeRellenoId=@TipoDeRellenoId";
                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters
                            .AddWithValue("@TipoDeRellenoId", tipoId);

                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si está relacionadoiste el tipo de Relleno");
            }

        }
        public bool Existe(TipoDeRelleno tipoDeRelleno)
        {
            try
            {
                using (var conn = new SqlConnection(_cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT * FROM TiposDeRellenos ";
                    if (tipoDeRelleno.TipoDeRellenoId == 0)
                    {
                        string conditional = "WHERE Descripcion = @Descripcion";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        using (var cmd = new SqlCommand(finalQuery, conn))
                        {
                            cmd.Parameters
                                .AddWithValue("@Descripcion", tipoDeRelleno.Descripcion);

                            using (var reader = cmd.ExecuteReader())
                            {
                                return reader.HasRows;
                            }
                        }

                    }
                    else
                    {
                        string conditional = "WHERE Descripcion = @Descripcion AND TipoDeRellenoId<>@TipoDeRellenoId";
                        string finalQuery = string.Concat(selectQuery, conditional);
                        using (var cmd = new SqlCommand(finalQuery, conn))
                        {
                            cmd.Parameters
                                .AddWithValue("@Descripcion", tipoDeRelleno.Descripcion);
                            cmd.Parameters
                                .AddWithValue("@TipoDeRellenoId", tipoDeRelleno.TipoDeRellenoId);

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

                throw new Exception("No se pudo comprobar si existe el tipo de nuez");
            }
        }
        public void Agregar(TipoDeRelleno tipoDeRelleno)
        {
            int primaryKey = -1;
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO TiposDeRellenos (Descripcion) 
                    VALUES(@Descripcion); SELECT @@IDENTITY";
                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters
                        .AddWithValue("@Descripcion", tipoDeRelleno.Descripcion);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        primaryKey = Convert.ToInt32(result);
                        tipoDeRelleno.TipoDeRellenoId = primaryKey;
                    }
                    else
                    {
                        throw new Exception("No se pudo agregar el tipo de Relleno");
                    }
                }
            }
        }

        public void Borrar(int tipoDeRellenoId)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string deleteQuery = @"DELETE FROM TiposDeRellenos 
                    WHERE TipoDeRellenoId=@TipoDeRellenoId";
                using (var cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters
                        .AddWithValue("@TipoDeRellenoId", tipoDeRellenoId);

                    int registrosAfectados = cmd.ExecuteNonQuery();
                    if (registrosAfectados == 0)
                    {
                        throw new Exception("No se pudo borrar el tipo de Relleno");
                    }
                }
            }

        }
        public List<TipoDeRelleno> GetLista()
        {
            List<TipoDeRelleno> lista = new List<TipoDeRelleno>();
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                var selectQuery = @"SELECT TipoDeRellenoId, Descripcion FROM 
                    TiposDeRellenos ORDER BY Descripcion";
                using (var cmd = new SqlCommand(selectQuery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tipoDeRelleno = ConstruirTipo(reader);
                            lista.Add(tipoDeRelleno);
                        }
                    }
                }
            }
            return lista;
        }

        private TipoDeRelleno ConstruirTipo(SqlDataReader reader)
        {
            return new TipoDeRelleno
            {
                TipoDeRellenoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Editar(TipoDeRelleno tipoDeRelleno)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            {
                conn.Open();
                string updateQuery = @"UPDATE TiposDeRellenos SET Descripcion=@Descripcion 
                    WHERE TipoDeRellenoId=@TipoDeRellenoId";
                using (var cmd = new SqlCommand(updateQuery, conn))
                {

                    cmd.Parameters
                        .AddWithValue("@Descripcion", tipoDeRelleno.Descripcion);
                    cmd.Parameters
                        .AddWithValue("@TipoDeRellenoId", tipoDeRelleno.TipoDeRellenoId);

                    int registrosAfectados = cmd.ExecuteNonQuery();
                    if (registrosAfectados == 0)
                    {
                        throw new Exception("No se pudo editar el tipo de Relleno");
                    }
                }
            }
        }
    }
}