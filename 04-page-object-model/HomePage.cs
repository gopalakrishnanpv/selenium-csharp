﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_page_object_model
{
	public class HomePage
	{
		IWebDriver _driver;

		[FindsBy(How = How.Id, Using = "name")]
		private IWebElement nameTextBox;

		[FindsBy(How = How.Id, Using = "age")]
		private IWebElement ageTextBox;

		[FindsBy(How = How.Id, Using = "email")]
		private IWebElement emailTextBox;

		public HomePage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(_driver, this);
		}

		public void EnterName(string name)
		{
			nameTextBox.SendKeys(name);
		}

		public void EnterAge(int age)
		{
			ageTextBox.SendKeys($"{age}");
		}

		public void EnterEmail(string email)
		{
			emailTextBox.SendKeys(email);
		}
	}
}


