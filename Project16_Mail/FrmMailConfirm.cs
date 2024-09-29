﻿using System;
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
    public partial class FrmMailConfirm : Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }

        Db16Project20Entities context = new Db16Project20Entities();
        public string email;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var value = context.TblUser.Where(x => x.Email == txtEmail.Text).Select(y => y.ConfirmCode).FirstOrDefault();

            if(txtConfirmCode.Text == value.ToString())
            {
                var value2 = context.TblUser.Where(x => x.Email == txtEmail.Text).FirstOrDefault();
                value2.IsConfirm = true;
                context.SaveChanges();
                MessageBox.Show("Hesabınız aktif edildi");
            }

            else
            {
                MessageBox.Show("Hatalı Kod");
            }
        }

        private void FrmMailConfirm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;

        }
    }
}
