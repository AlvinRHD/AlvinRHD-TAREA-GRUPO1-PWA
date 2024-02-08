using Biblioteca.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using static Biblioteca.Models.BibliotecaModel;

namespace Biblioteca.Data
{
    public class BibliotecaData
    {
        string connectionString = "Data Source = GATEWAY; Initial Catalog = DBLibrary; Integrated Security = True";


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
                            BibliotecaModel.Books book = new BibliotecaModel.Books();
                            book.LibroId = Convert.ToInt32(reader["LibroId"]);
                            book.Titulo = reader["Titulo"].ToString();
                            book.PublishDate = Convert.ToInt32(reader["PublishDate"]);
                            book.ISBN = Convert.ToInt32(reader["ISBN"]);
                            book.Genero = reader["Genero"].ToString();

                            BibliotecaModel.Autor autor = new BibliotecaModel.Autor();
                            autor.AutorId = Convert.ToInt32(reader["AutorId"]);
                            autor.Nombre = reader["AutorNombre"].toString();
                            autor.Edad = reader["Edad"].ToString();
                            autor.FechaNacimiento = Convert.ToInt32(reader["FechaNacimiento"]);
                            autor.Nacionalidad = reader["Nacionalidad"].ToString();

                            BibliotecaModel.Editorial editorial = new BibliotecaModel.Editorial();
                            editorial.EditorialId = Convert.toInt32(reader["EditorialId"]);
                            editorial.Nombre = reader["EditorialNombre"].ToString();
                            editorial.AÑO = Convert.ToInt32(reader["EditorialAño"]);
                            editorial.TipoEditorial = reader["TipoEditorial"].ToString();
                            editorial.Ubicacion = reader["Ubicacion"].ToString();

                            bibliotecaList.Add(bibliotecaModel);
                        }
                    }
                }
            }
            return bibliotecaList;
        }
        public BibliotecaModel? GetById(int id)
        {
            BibliotecaModel bibliotecaModel = new BibliotecaModel();

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

                    command.Parameters.AddWithValue("@Id", id);

                    command.CommandType = CommandType.Text;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            book.LibroId = Convert.ToInt32(reader["LibroId"]);
                            book.Titulo = reader["Titulo"].ToString();
                            book.PublishDate = Convert.ToInt32(reader["PublishDate"]);
                            book.ISBN = Convert.ToInt32(reader["ISBN"]);
                            book.Genero = reader["Genero"].ToString();

                            autor.AutorId = Convert.ToInt32(reader["AutorId"]);
                            autor.Nombre = reader["AutorNombre"].toString();
                            autor.Edad = reader["Edad"].ToString();
                            autor.FechaNacimiento = Convert.ToInt32(reader["FechaNacimiento"]);
                            autor.Nacionalidad = reader["Nacionalidad"].ToString();

                            editorial.EditorialId = Convert.toInt32(reader["EditorialId"]);
                            editorial.Nombre = reader["EditorialNombre"].ToString();
                            editorial.AÑO = Convert.ToInt32(reader["EditorialAño"]);
                            editorial.TipoEditorial = reader["TipoEditorial"].ToString();
                            editorial.Ubicacion = reader["Ubicacion"].ToString();
                        }
                    }

                }
            }

            return bibliotecaModel;
        }
        
        public void Add(BibiotecaModel bibioteca) 
        {
            using (var connetion = new SqlConnetion(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connetion;

                    command.CommandText = @"INSERT INTO Autor
                                            VALUES (@Nombre, @Edad, @FechaNacimiento, @Nacionalidad)";

                    command.CommandParameters.AddWithValue = @"INSERT INTO Books";
                            command.Parameters.AddWithValue = ("", employee.LastName):
                                                  command.Parmeters.AddWithValue("@Phone", employee.Phone);

                }
            }
        }

    }
}
