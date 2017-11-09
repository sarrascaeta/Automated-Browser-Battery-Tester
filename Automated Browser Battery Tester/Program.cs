using AutomatedBrowserBatteryTester.Managers;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Automated_Browser_Battery_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());


            var driver = BrowserManager.CreateBrowser();



        }
    }
}
