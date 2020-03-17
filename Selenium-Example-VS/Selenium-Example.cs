using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Example_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
            //driver.Manage().Window.Maximize();

            //Login(User and Pass: tutorial)
            IWebElement username = driver.FindElement(By.Name("userName"));
            username.SendKeys("tutorial");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("tutorial");
            IWebElement login = driver.FindElement(By.Name("login"));
            //login.SendKeys(Keys.Enter);
            login.Click();

            //Vuelo desde Acapulco hacia Londres(cualquier fecha)

            //Seleccionar First Class
            
            //Click en Continue
            
            //Seleccionar el segundo vuelo en la primera lista
            
            //Seleccionar el tercer vuelo en la segunda lista
            
            //Click en Continue
            
            //Completar los datos del pasajero
            
            //Click en Secure Purchase
            
            //Verificar que el mensaje Your itinerary has been booked! es mostrado en pantalla
        }
    }
}
