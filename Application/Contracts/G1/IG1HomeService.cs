using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ExtracaoNoticias.Application.Contracts.G1
{
    internal interface IG1HomeService
    {
        ChromeDriver Open();
    }
}
