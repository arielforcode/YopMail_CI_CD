using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopMail_CI_CD.src.code.control;

namespace YopMail_CI_CD.src.code.pages
{
    public class MainPage
    {
        public TextBox textBoxUsername = new TextBox(By.Id("login"));
        public Button loginButton = new Button(By.Id("refreshbut"));
        public Button newEmail = new Button(By.Id("newmail"));
        public Button refresh = new Button(By.Id("refresh"));
    }
}
