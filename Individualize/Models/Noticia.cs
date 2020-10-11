using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Noticia
    {
        public short NoticiaId { get; set; }
        public string NoticiaDsc { get; set; }
        public string NoticiaResumo { get; set; }
        public string NoticiaTexto { get; set; }
        public byte[] NoticiaImg { get; set; }
        public DateTime NoticiaData { get; set; }
        public string NoticiaImgNome { get; set; }
        public string NoticiaImgTipo { get; set; }
    }
}
