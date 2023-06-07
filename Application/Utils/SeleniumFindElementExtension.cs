using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ExtracaoNoticias.Application.Extensions
{
    internal static class SeleniumFindElementExtension
    {
        public static IWebElement TryFindElement(this IWebElement element, By by)
        {
			try
			{
                return element.FindElement(by);
            }
			catch (Exception)
			{
                return null;
			}
        }
    }
}
