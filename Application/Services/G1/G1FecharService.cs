
using G1ExtracaoNoticias.Application.Contracts.G1;
using OpenQA.Selenium.Chrome;

namespace G1ExtracaoNoticias.Application.Services.G1
{
    internal class G1FecharService : IG1FecharService
    {
        public void Execute(ChromeDriver driver)
        {
            driver.Close();
        }
    }
}
