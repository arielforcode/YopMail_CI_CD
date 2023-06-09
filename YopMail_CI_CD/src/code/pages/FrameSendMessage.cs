﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopMail_CI_CD.src.code.control;

namespace YopMail_CI_CD.src.code.pages
{
    public class FrameSendMessage
    {
        public TextBox emailSend = new TextBox(By.Id("msgto"));
        public TextBox titleMail = new TextBox(By.Id("msgsubject"));
        public TextBox bodyMail = new TextBox(By.Id("msgbody"));
        public Button sendMail = new Button(By.Id("msgsend"));
    }
}
