using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Robo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a url do site");
            string site = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(site))
            {
                Console.WriteLine("Digite a url do site");
                site = Console.ReadLine();
            }

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(site);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IWebElement rodape = driver.FindElement(By.XPath("/html/body/app-root/app-login/section/form/div[2]/div[1]/div"));
            rodape.Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));
            IWebElement inputUsuario = driver.FindElement(By.XPath("//*[@id=\"usuario\"]"));
            inputUsuario.SendKeys("usuario");

            Thread.Sleep(TimeSpan.FromSeconds(1));
            IWebElement inputSenha = driver.FindElement(By.XPath("//*[@id=\"senha\"]"));
            inputSenha.SendKeys("senha");

            IWebElement btnEntrar = driver.FindElement(By.XPath("//*[@id=\"wave\"]/div/div/div[1]/div/div[2]/button"));
            btnEntrar.Click();

            Console.ReadKey();
        }
    }
}
