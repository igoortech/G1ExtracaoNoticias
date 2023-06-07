using G1ExtracaoNoticias.Application.Model;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace G1ExtracaoNoticias.Application.Contracts.G1
{
    internal interface IG1ObterInfoService
    {
        IEnumerable<G1Informacao> Execute(ChromeDriver driver, int limite);
    }
}
