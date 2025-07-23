using System;

namespace LagerverwaltungApp.Models
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ort { get; set; } = string.Empty;
        public string Regal { get; set; } = string.Empty;
        public string Kiste { get; set; } = string.Empty;
        public string Schublade { get; set; } = string.Empty;
        public string Schrank { get; set; } = string.Empty;
        public string Anwendung { get; set; } = string.Empty;
        public int Menge { get; set; }
        public string InternetHinweis { get; set; } = string.Empty;

        // Bild als Byte-Array
        public byte[] Bild { get; set; } = Array.Empty<byte>();
    }
}
