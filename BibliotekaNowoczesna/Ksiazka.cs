using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaNowoczesna;

    public class Ksiazka
    {
    public Ksiazka() { }
    public Ksiazka(string? isbn, string? tytul)
    {
        Isbn = isbn;
        Tytul = tytul;
    }

        public required string? Isbn { get; set; }
        public required string? Tytul {  get; set; }
        public string? Autor {  get; set; }
        public int LiczbaStron { get; set; }
    }

