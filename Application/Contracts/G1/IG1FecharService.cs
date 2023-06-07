using OpenQA.Selenium.Chrome;

namespace G1ExtracaoNoticias.Application.Contracts.G1
{
    internal interface IG1FecharService
    {
        void Execute(ChromeDriver driver);
    }
}
