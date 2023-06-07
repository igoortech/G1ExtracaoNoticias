using G1ExtracaoNoticias.Application.Services.G1;

namespace G1ExtracaoNoticias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var g1HomeService = new G1HomeService();
            var g1GetInfoService = new G1ObterInfoService();
            var g1FecharService = new G1FecharService();

            var driver = g1HomeService.Open();

            g1GetInfoService.Execute(driver);

            g1FecharService.Execute(driver);
        }
    }
}
