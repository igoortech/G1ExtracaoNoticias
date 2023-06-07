using G1ExtracaoNoticias.Application.Model;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ExtracaoNoticias.Application.Utils
{
    internal static class CsvUtils
    {

        public static void ListObjectToCsv(List<G1Informacao> reportData, string file)
        {
            var data = GerenateData(reportData);

            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }

            File.WriteAllText(file, data, Encoding.UTF8);
        }

        private static string GerenateData(List<G1Informacao> informacoes)
        {
            var props = TypeDescriptor.GetProperties(typeof(G1Informacao)).OfType<PropertyDescriptor>();
            var header = string.Join(";", props.Select(property => property.Name));
            var lines = new List<string> { header };

            lines.AddRange(informacoes.Select(row =>
            {
                return $"{row.Titulo};{row.Descricao};{string.Join(",", row.SubDescricoes)};{row.PublicadoEm};{row.Localizacao}";
            }));

            return string.Join("\n", lines);
        }
    }
}
