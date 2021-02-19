using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
   partial class ProductPage
    {
      
        public void AddInCart()
        {
            AdaugaInCosButton.Click();
        }
        public void AddToFavorites()
        {
            AdaugaLaFavorite.Click();
        }

        public void DetailsProduct()
        {
            VeziToate.Click();
        }
    }
}
