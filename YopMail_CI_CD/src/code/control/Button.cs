using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YopMail_CI_CD.src.code.control
{
    public class Button:ControlSelenium
    {
        public Button(By Locator) : base(Locator)
        {

        }
    }
}
