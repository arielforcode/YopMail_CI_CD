using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using YopMail_CI_CD.src.code.pages;
using YopMail_CI_CD.src.code.session;
using YopMail_CI_CD.src.code.test;

namespace YopMail_CI_CD
{
    [Binding]
    public class TestStepDefinitions
    {
        MainPage mainPage = new MainPage();
        FrameSendMessage message = new FrameSendMessage();
        TestBase testbase = new TestBase();
        string username = "ximena";
        string title = "prueba";


        [Given(@"I have the website")]
        public void GivenIHaveTheWebsite()
        {
            testbase.OpenBrowser();
        }

        [When(@"Create user")]
        public void WhenCreateUser()
        {
            mainPage.textBoxUsername.SetText(username);
            mainPage.loginButton.Click();
        }

        [Then(@"I see the control panel")]
        public void ThenISeeTheControlPanel()
        {
            Assert.IsTrue(Session.Instance().GetBrowser().FindElement(By.XPath("//a[@class='wmlogoclick']")).Displayed, "Error failed init session, please check credentials");
        }


        [Given(@"Open Mail Screen")]
        public void GivenOpenMailScreen()
        {
            mainPage.newEmail.Click();
            Session.Instance().GetBrowser().SwitchTo().Frame("ifmail");
        }

        [When(@"Write Email to send")]
        public void WhenWriteEmailToSend()
        {
            message.emailSend.SetText(username + "@yopmail.com");
            message.titleMail.SetText(title);
            message.bodyMail.SetText("Correo de prueba para verificar envios");
            message.sendMail.Click();
        }

        [Then(@"Check mail delivery")]
        public void ThenCheckMailDelivery()
        {
            Thread.Sleep(4000);
            Assert.IsTrue(Session.Instance().GetBrowser().FindElement(By.Id("msgpopmsg")).Displayed, "Error send message mail");
        }

        [Given(@"Switch to Inbox Section")]
        public void GivenSwitchToInboxSection()
        {
            Session.Instance().GetBrowser().SwitchTo().DefaultContent();
            mainPage.refresh.Click();
            Session.Instance().GetBrowser().SwitchTo().Frame("ifinbox");
        }

        [When(@"Check mail sent in the mailbox")]
        public void WhenCheckMailSentInTheMailbox()
        {
            Assert.IsTrue(Session.Instance().GetBrowser().FindElement(By.XPath("//div[@class='mctn']//div[@class='m']//button//div[text()='" + title + "']")).Displayed, "ERROR recived email failed");
        }

        [Then(@"Close browser")]
        public void ThenCloseBrowser()
        {
            testbase.CloseBrowser();
        }
    }
}
