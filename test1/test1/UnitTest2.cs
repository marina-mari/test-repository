﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test1
{
    [TestFixture]
    public class UnitTest2 
    {
        private IWebDriver driver;
        [SetUp]

        public void start()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void loginform_chrome()
        {
            //driver.Url = "http://localhost/litecart/admin/";
            driver.Navigate().GoToUrl("http://localhost/litecart/admin/");
            var username = driver.FindElement(By.Name("username"));
            username.SendKeys("admin");
            var password = driver.FindElement(By.Name("password"));
            password.SendKeys("admin");
            var submit = driver.FindElement(By.Name("login"));
            submit.Click();

        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
