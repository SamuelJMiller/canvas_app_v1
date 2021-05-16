using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace canvas_app_v1
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            main_menu.Items.Add("File");

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Save and Upload");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Close App");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Log Out");
        }
    }
}
