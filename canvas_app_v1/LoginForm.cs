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
        main_form mainform;

        public login_form(main_form mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        // So the user can't bypass login:
        private void login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
