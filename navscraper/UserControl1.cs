using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace navscraper
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Enter(object sender, EventArgs e)
        {
            if (txtbx.Text == this.Tag.ToString())
            {
                txtbx.ResetText();
                txtbx.BackColor = Color.White;
                txtbx.ForeColor = Color.Black;
            }
        }

        private void txtbx_Validating(object sender, CancelEventArgs e)
        {
            txtbx.Text = this.Tag.ToString();
        }

        private void txtbx_Leave(object sender, EventArgs e)
        {
            if (txtbx.TextLength == 0)
            {
                
                txtbx.BackColor = Color.WhiteSmoke;
                txtbx.ForeColor = Color.DimGray;
            }
        }
    }
}
