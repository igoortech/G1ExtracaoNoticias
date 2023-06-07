using G1ExtracaoNoticias.Application.Contracts.G1;
using G1ExtracaoNoticias.Application.Extensions;
using G1ExtracaoNoticias.Application.Model;
using G1ExtracaoNoticias.Application.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace G1ExtracaoNoticias.Application.Services.G1
{
    internal class G1ObterInfoService : IG1ObterInfoService
    {
        public IEnumerable<G1Informacao> Execute(ChromeDriver driver, int limite = 5)
        {
            var csvOutput = "";

            Console.WriteLine("Iniciando captura dos dados");

            var list = new List<G1Informacao>();

            var elements = driver.FindElements(By.ClassName("feed-post-body"));

            var contador = 0;
            foreach(var element in elements)
            {
                contador++;
                if (contador > limite)
                {
                    break;
                }

                var titulo = element.TryFindElement(By.ClassName("feed-post-link"))?.Text;
                var descricao = element.TryFindElement(By.ClassName("feed-post-body-resumo"))?.Text;
                var publicadoEm = element.TryFindElement(By.ClassName("feed-post-datetime"))?.Text;
                var localizado = element.TryFindElement(By.ClassName("feed-post-metadata-section"))?.Text;

                var subs = element.FindElements(By.ClassName("bstn-relatedtext"));

                var subDescricoes = new List<string>();
                foreach (var subDescricao in subs)
                {
                    subDescricoes.Add(subDescricao.Text);
                }

                Console.WriteLine($"Dados capturados:\nTitulo: {titulo}\nDescricao: {descricao}\nPublicado em: {publicadoEm}\nLocalizado: {localizado}\nSubDescricoes: {string.Join("\n", subDescricoes)}");
                Console.WriteLine($"\n///////////////////////              //////////////////////////////\n");

                var informacao = new G1Informacao
                {
                    Titulo = titulo,
                    Descricao = descricao,
                    PublicadoEm = publicadoEm,
                    Localizacao = localizado,
                    SubDescricoes = subDescricoes
                };

                list.Add(informacao);

                CsvUtils.ListObjectToCsv(list, csvOutput);
            }


            return list;
        }
    }
}
