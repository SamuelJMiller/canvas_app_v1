using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
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
        private const string APP_NAME = "Canvas Page Manager"; // Name of the app which will not change
        private bool page_edited = false; // True if the page the user is editing has been edited and not saved

        public main_form()
        {
            InitializeComponent();
        }

        private void RemoveLabels()
        {
            // Remove labels if they exist:
            if ((tut_label_top != null) && (tut_label_bottom_1 != null) && (tut_label_bottom_2 != null))
            {
                tut_label_top.Dispose();
                tut_label_bottom_1.Dispose();
                tut_label_bottom_2.Dispose();
            }
        }

        private void AddHtmlEditor()
        {
            HTMLEditControl hec = new HTMLEditControl();
            this.Controls.Add(hec);
            hec.Parent = right_panel;
            hec.Dock = DockStyle.Fill;
            hec.Name = "main_editor";

            RemoveLabels(); // No more need for labels
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            // Add menu items:
            main_menu.Items.Add("File");

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Save and Upload");

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Close App");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems[1].Click += new EventHandler(file_closeapp_click);

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Log Out");

            // Expand first class node in TreeView, if exists:
            if (main_tree.Nodes[0].Nodes.Count > 0) // If node is an actuall class, not just the message
            {
                main_tree.Nodes[0].Expand();
            }
        }

        private void main_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // If node selected is a child node:
            if (main_tree.SelectedNode.Parent != null)
            {
                // Remove the old editor:
                if (right_panel.Controls.Find("main_editor", false).Count() > 0) {
                    HTMLEditControl hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;
                    hec.Dispose();
                }

                // Add new editor:
                AddHtmlEditor();

                // Add page text to new editor:
                HTMLEditControl new_hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;
                // TODO ------ MAKE THIS BE THE ACTUAL CANVAS CLASS PAGE TEXT WHEN STUFF IS READY ------------------------------------
                new_hec.DocumentHTML = main_tree.SelectedNode.Text;
                
                // Setup top text
                this.Text = APP_NAME + " - " + main_tree.SelectedNode.Parent.Text + " - " + main_tree.SelectedNode.Text;
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

        // Close the app if the user opts to:
        private void file_closeapp_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Toggle tutorial on/off:
        /*private void tutorial_toggle_click(object sender, EventArgs e)
        {
            Label[] tut_labels = { tut_label_top, tut_label_bottom_1, tut_label_bottom_2 };
            ConfigurationUserLevel security = ConfigurationUserLevel.None;
            Configuration config = ConfigurationManager.OpenExeConfiguration(security);
            AppSettingsSection app = config.AppSettings;

            // If visible, make invisible:
            if (tut_label_top.Visible && tut_label_bottom_1.Visible && tut_label_bottom_2.Visible)
            {
                foreach ( Label l in tut_labels )
                {
                    app.Settings.Remove("tutorialEnabled");
                    app.Settings.Add("tutorialEnabled", "false");
                    l.Visible = false;
                }
            } else // Otherwise do the opposite:
            {
                foreach (Label l in tut_labels)
                {
                    app.Settings.Remove("tutorialEnabled");
                    app.Settings.Add("tutorialEnabled", "true");
                    l.Visible = true;
                }
            }
        }*/
    }
}
