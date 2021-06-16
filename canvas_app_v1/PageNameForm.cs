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
    public partial class PageNameForm : Form
    {
        private string file_name;

        public PageNameForm()
        {
            InitializeComponent();
        }

        public string FileName()
        {
            return file_name;
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            if (name_box.Text.Length > 0)
            {
                file_name = name_box.Text;
                this.Close();
            } else
            {
                MessageBox.Show("You must provide a name!");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
