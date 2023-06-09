using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YopMail_CI_CD.src.code.test
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/es/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
