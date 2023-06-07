using G1ExtracaoNoticias.Application.Contracts.G1;
using OpenQA.Selenium.Chrome;
using System;

namespace G1ExtracaoNoticias.Application.Services.G1
{
    internal class G1HomeService : IG1HomeService
    {
        public ChromeDriver Open()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://g1.globo.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}
