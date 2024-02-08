namespace Biblioteca.Models
{
    public class BibliotecaModel
    {
        public class Autor
        {
            public int AutorId { get; set; }
            public string Nombre { get; set; }
            public string Edad { get; set; }
            public int FechaNacimiento { get; set; }
            public string Nacionalidad { get; set; }
        }

        public class Editorial
        {
            public int EditorialId { get; set; }
            public string Nombre { get; set; }
            public int AÑO { get; set; }
            public string TipoEditorial { get; set; }
            public string Ubicacion { get; set; }
        }

        public class Books
        {
            public int LibroId { get; set; }
            public string Titulo { get; set; }
            public int PublishDate { get; set; }
            public int ISBN { get; set; }
            public string Genero { get; set; }
        }
    }
}
