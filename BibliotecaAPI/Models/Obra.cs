using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaAPI.Models
{
    public class Obra
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Foto { get; set; }
        [NotMapped]
        public List<string> Autores { get; set; }
    }
}
