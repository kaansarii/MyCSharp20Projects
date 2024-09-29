﻿using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db16Project20Entities context = new Db16Project20Entities();
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int confirmCode = random.Next(100000, 1000000);

            TblUser user = new TblUser();

            user.Email = txtEmail.Text;
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.IsConfirm = false;
            user.ConfirmCode = confirmCode.ToString();

            context.TblUser.Add(user);
            context.SaveChanges();







            #region MailKodları

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister", "mail adresi");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Email adresinizin konf kodu: " + confirmCode;

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Email Konf. Kodu";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("mail", "key");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            MessageBox.Show("Mail Adresinize doğrulama kodu gönderildi");

            FrmMailConfirm frmMail = new FrmMailConfirm();
            frmMail.email = txtEmail.Text;
            frmMail.Show();

            #endregion
        }
    }
}