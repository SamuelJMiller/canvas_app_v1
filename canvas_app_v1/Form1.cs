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
using Zoople;

namespace canvas_app_v1
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void AddHtmlEditor()
        {
            HTMLEditControl hec = new HTMLEditControl();
            this.Controls.Add(hec);
            hec.Parent = right_panel;
            hec.Dock = DockStyle.Fill;
            hec.Name = "main_editor";
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            // Add menu items:
            main_menu.Items.Add("File");

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Save and Upload");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Close App");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Log Out");

            // Expand first class node in TreeView, if exists:
            if (main_tree.Nodes[0].Nodes.Count > 0) // If node is an actuall class, not just the message
            {
                main_tree.Nodes[0].Expand();
            }

            AddHtmlEditor();
        }

        private void main_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // If node selected is a child node:
            if (main_tree.SelectedNode.Parent != null)
            {
                // Remove the old editor:
                HTMLEditControl hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;
                hec.Dispose();

                // Add new editor:
                /*AddHtmlEditor();

                // Setup next text in new editor:
                for ( int i = 0; i < this.Controls.Count; ++i )
                {
                    if (this.Controls[i].Name == "main_editor")
                    {
                        HTMLEditControl hec = (HTMLEditControl) this.Controls[i];

                        // | TEMPORARY - REPLACE WITH PAGE TEXT |
                        
                    }
                }*/
            }  else
            {
                // Close all nodes except for the selected one, which is expanded:
                main_tree.SelectedNode.Expand();
                foreach ( TreeNode n in main_tree.Nodes )
                {
                    if (n != main_tree.SelectedNode)
                    {
                        n.Collapse();
                    }
                }
            }
        }
    }
}
