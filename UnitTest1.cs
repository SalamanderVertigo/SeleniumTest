using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;

namespace SeleniumTestProject
{
    public class Tests
    {

        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("SETUP the Test");

            new DriverManager().SetUpDriver(new ChromeConfig());

            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("RUn the Test");

            Driver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(Driver.Title.Contains("Google"));
        }
    }
}