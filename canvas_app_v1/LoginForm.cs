using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace canvas_app_v1
{
    public partial class login_form : Form
    {
        private main_form mainform;
        private bool user_authenticated = false;

        public login_form(main_form mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        // So the user can't bypass login:
        private void login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user_authenticated == false)
            {
                Application.Exit();
            }
        }

        private void username_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If presses enter:
            if (e.KeyChar == 13)
            {
                if (username_box.Text == string.Empty || password_box.Text == string.Empty)
                {
                    MessageBox.Show("You must supply information to both fields!");
                } else
                {
                    user_authenticated = true;
                    this.Close();
                }
            }
        }

        private void password_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (username_box.Text == string.Empty || password_box.Text == string.Empty)
                {
                    MessageBox.Show("You must supply information to both fields!");
                } else
                {
                    user_authenticated = true;
                    this.Close();
                }
            }
        }
    }
}
