using System.Collections.Generic;

namespace G1ExtracaoNoticias.Application.Model
{
    internal class G1Informacao
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public List<string> SubDescricoes { get; set; } = new List<string>();
        public string PublicadoEm { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
    }
}
