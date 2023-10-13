using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjektakNuker
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting browser...");
            IWebDriver driver = new ChromeDriver();
            Console.WriteLine("Opening page...");
            driver.Navigate().GoToUrl("https://poll.ly/qdSK0ZQlirguTNNBxnCg");

        }
    }
}