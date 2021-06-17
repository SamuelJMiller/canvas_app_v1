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
        private const string APP_NAME = "Canvas Desktop"; // Name of the app which will not change
        private const string BASE_URL = "https://centralia.instructure.com/api/v1/"; // All API access starts here
        private const string TEST_TOKEN = "9~Uo3aHRPFGxOZ3XJJXh97uYceOhwk8z4XQKkSCZylTCsJOqHHHIp8aA8BBUbDVRm9";
        private bool page_edited = false; // True if the page the user is editing has been edited and not saved
        private FileUpload fu = new FileUpload();

        private dynamic my_courses;
        private List<dynamic> page_groups = new List<dynamic>(); // Holds the pages for each course (not currently in use)
        private TreeNode current_page; // Will be set to the current child node, when it gets selected
        private TreeNode current_class;

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

            // Set to edited if user edits anything on the page:
            hec.HTMLChanged += new HTMLEditControl.HTMLChangedEventHandler(on_html_edit);

            // Enable "save" button:
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems[0].Enabled = true;

            RemoveLabels(); // No more need for labels
        }

        private async void main_form_Load(object sender, EventArgs e)
        {
            //  Initialize login: (may be implemented when we can get a dev token for OAuth)
            //login_form lf = new login_form(this);
            //lf.ShowDialog();

            // Add menu items:
            main_menu.Items.Add("File");

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Save and Upload");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems[0].Click += new EventHandler(file_saveandupload_click);
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems[0].Enabled = false;

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Close App");
            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems[1].Click += new EventHandler(file_closeapp_click);

            (main_menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Log Out");

            // Disable new page button by default:
            new_page_button.Enabled = false;

            // Get courses and put them in the tree:
            my_courses = await HttpUtilities.get_teacher_courses(BASE_URL, TEST_TOKEN);
            
            if (my_courses.Count > 0) // If there are courses
            {
                for ( int i = 0; i < my_courses.Count; ++i )
                {
                    TreeNode t = main_tree.Nodes.Add(JsonConvert.SerializeObject(my_courses[i]["name"]).Trim('"'));

                    t.Nodes.Add("Syllabus");
                    // Get pages for each course and put them as subnodes under the course:
                    dynamic pages = await HttpUtilities.get_course_pages(BASE_URL, TEST_TOKEN,
                        JsonConvert.SerializeObject(my_courses[i]["id"]));

                    if (pages.Count > 0) // If there are pages associated with the course
                    {
                        for ( int j = 0; j < pages.Count; ++j )
                        {
                            t.Nodes.Add(JsonConvert.SerializeObject(pages[j]["title"]).Trim('"'));
                        }
                    }
                }
            }

            // Expand first class node in TreeView, if exists:
            if (main_tree.Nodes.Count > 0) // If there are classes
            {
                main_tree.Nodes[0].Expand();
            }
        }

        private async void main_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Show a message if the user tries to switch pages without saving:
            if (page_edited)
            {
                MessageBox.Show("Please save your changes!");
                return;
            }

            // If node selected is a child node:
            if (main_tree.SelectedNode.Parent != null)
            {
                // Set current_page and current_class to appropriate nodes:
                current_page = main_tree.SelectedNode;
                current_class = current_page.Parent;

                // Disable new page button, if not already:
                if (new_page_button.Enabled == true)
                {
                    new_page_button.Enabled = false;
                }

                // Remove the old editor:
                if (right_panel.Controls.Find("main_editor", false).Count() > 0) {
                    HTMLEditControl hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;
                    hec.Dispose();
                }

                // Add new editor:
                AddHtmlEditor();

                // Add page text to new editor:
                HTMLEditControl new_hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;
                
                for ( int i = 0; i < my_courses.Count; ++i )
                {
                    if (JsonConvert.SerializeObject(my_courses[i]["name"]).Trim('"') == main_tree.SelectedNode.Parent.Text)
                    {
                        if (main_tree.SelectedNode.Text == "Syllabus") {
                            dynamic syllabus = await HttpUtilities.get_course_syllabus(BASE_URL, TEST_TOKEN,
                                JsonConvert.SerializeObject(my_courses[i]["id"]).Trim('"'));

                            new_hec.DocumentHTML = JsonConvert.SerializeObject(syllabus["syllabus_body"]).Trim('"');
                        } else
                        {
                            // Kind of inefficient, can we fix the repeated requesting?
                            dynamic pages = await HttpUtilities.get_course_pages(BASE_URL, TEST_TOKEN,
                                JsonConvert.SerializeObject(my_courses[i]["id"]));

                            for (int j = 0; j < pages.Count; ++j)
                            {
                                if (JsonConvert.SerializeObject(pages[j]["title"]).Trim('"') == main_tree.SelectedNode.Text)
                                {
                                    dynamic page = await HttpUtilities.get_single_page(BASE_URL, TEST_TOKEN,
                                        JsonConvert.SerializeObject(my_courses[i]["id"]).Trim('"'),
                                        JsonConvert.SerializeObject(pages[j]["url"]).Trim('"'));

                                    string page_content = JsonConvert.SerializeObject(page["body"]).Trim('"');

                                    if (page_content != "null")
                                    {
                                        new_hec.DocumentHTML = page_content;
                                    } else
                                    {
                                        new_hec.DocumentHTML = string.Empty;
                                    }
                                }
                            }
                        }
                    }
                }
                
                // Setup top text
                this.Text = APP_NAME + " - " + main_tree.SelectedNode.Parent.Text + " - " + main_tree.SelectedNode.Text;
            }  else
            {
                // Set current_class appropriately:
                current_class = main_tree.SelectedNode;

                // Enable new page button, if not already:
                if (new_page_button.Enabled == false)
                {
                    new_page_button.Enabled = true;
                }

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

        // Save and upload pages:
        private async void file_saveandupload_click(object sender, EventArgs e)
        {
            if (page_edited)
            {
                page_edited = false;
                this.Text = this.Text.Remove(this.Text.Length - 1); // Take the star off if saved
            }

            HTMLEditControl hec = null;

            // Find editor:
            if (right_panel.Controls.Find("main_editor", false).Count() > 0)
            {
                hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;
            }

            // Find correct page:
            for ( int i = 0; i < my_courses.Count; ++i )
            {
                if (JsonConvert.SerializeObject(my_courses[i]["name"]).Trim('"') == current_page.Parent.Text)
                {
                    if (current_page.Text == "Syllabus") // Update syllabus
                    {
                        dynamic update_syl = await HttpUtilities.update_syllabus(BASE_URL, TEST_TOKEN,
                            JsonConvert.SerializeObject(my_courses[i]["id"]).Trim('"'),
                            hec.DocumentHTML);
                    } else // Update other page
                    {
                        // Kind of inefficient, can we fix the repeated requesting?
                        dynamic pages = await HttpUtilities.get_course_pages(BASE_URL, TEST_TOKEN,
                            JsonConvert.SerializeObject(my_courses[i]["id"]));

                        for (int j = 0; j < pages.Count; ++j)
                        {
                            if (JsonConvert.SerializeObject(pages[j]["title"]).Trim('"') == current_page.Text)
                            {
                                // Update page:
                                dynamic update = HttpUtilities.update_page(BASE_URL, TEST_TOKEN,
                                    JsonConvert.SerializeObject(my_courses[i]["id"]).Trim('"'),
                                    JsonConvert.SerializeObject(pages[j]["url"]).Trim('"'),
                                    hec.DocumentHTML);
                            }
                        }
                    }
                }
            }
        }

        // What to do when user edits:
        private void on_html_edit(object sender, EventArgs e)
        {
            if (page_edited == false)
            {
                page_edited = true;
                this.Text += '*'; // Add a star if editing
            }
        }

        private async void new_page_button_Click(object sender, EventArgs e)
        {
            PageNameForm pnf = new PageNameForm();
            pnf.ShowDialog();

            // Creat page at appropriate class:
            for ( int i = 0; i < my_courses.Count; ++i )
            {
                if (JsonConvert.SerializeObject(my_courses[i]["name"]).Trim('"') == current_class.Text)
                {
                    dynamic new_page = await HttpUtilities.create_page(BASE_URL, TEST_TOKEN,
                        JsonConvert.SerializeObject(my_courses[i]["id"]).Trim('"'), pnf.FileName());
                }
            }
        }

        // File upload testing: (Note: since this is now commented, the corresponding lines in the Designer.cs file
        // representing the addition and construction of the button/event handler are commented as well)
        //private async void file_in_Click(object sender, EventArgs e)
        //{
        //    string path = string.Empty;
        //    OpenFileDialog dialog = new();
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        path = dialog.FileName;
        //    }

        //    dynamic json = await fu.init_file_upload("testfile.txt");
        //    HTMLEditControl hec;

        //    AddHtmlEditor();

        //    hec = right_panel.Controls.Find("main_editor", false).First() as HTMLEditControl;

        //    string trimmed_url = JsonConvert.SerializeObject(json["upload_url"]).Trim('"');
        //    string received_filename = JsonConvert.SerializeObject(json["upload_params"]["filename"]).Trim('"');
        //    string received_content_type = JsonConvert.SerializeObject(json["upload_params"]["content_type"]).Trim('"');

        //    dynamic json2 = await fu.send_file(trimmed_url, received_filename, received_content_type, path);
        //    hec.DocumentHTML = JsonConvert.SerializeObject(json2);
        //}
    }
}
