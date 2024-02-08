using Biblioteca.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Biblioteca.Data
{
    public class BibliotecaData
    {
        string connectionString = "Data Source=SAVI5\\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True;Trust Server Certificate=True";

        public IEnumerable<BibliotecaModel> GetAll()
        {
            List<BibliotecaModel> BibliotecaList = new List<BibliotecaModel>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT B.LibroId, B.Nombre AS LibroNombre, B.PublishDate, B.ISBN, B.Genero, " +
                                          "A.AutorId, A.Nombre AS AutorNombre, A.Edad, A.FechaNacimiento, A.Nacionalidad, " +
                                          "E.EditorialId, E.Nombre AS EditorialNombre, E.AÑO AS EditorialAño, E.TipoEditorial, E.Ubicacion " +
                                          "FROM Books B " +
                                          "INNER JOIN Autor A ON B.AutorId = A.AutorId " +
                                          "INNER JOIN Editorial E ON B.EditorialId = E.EditorialId;";

                    command.CommandType = CommandType.Text;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BibliotecaModel bibliotecaModel = new BibliotecaModel();
                            

                            BibliotecaList.Add(bibliotecaModel);
                        }
                    }
                }
            }
        }
    }
}
