using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPI.Models
{
    public class Obra
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Foto { get; set; }
        public string Autores { get; set; }
    }
}
