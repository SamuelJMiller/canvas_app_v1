
namespace canvas_app_v1
{
    partial class main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Student Roster");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Syllabus");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Page1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Page2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Class1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Student Roster");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Syllabus");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Page1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Page2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Class2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.outer_panel = new System.Windows.Forms.Panel();
            this.main_tree = new System.Windows.Forms.TreeView();
            this.inner_panel = new System.Windows.Forms.Panel();
            this.classes_label = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.outer_panel.SuspendLayout();
            this.inner_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(800, 24);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "menuStrip1";
            // 
            // outer_panel
            // 
            this.outer_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outer_panel.BackColor = System.Drawing.SystemColors.Control;
            this.outer_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outer_panel.Controls.Add(this.main_tree);
            this.outer_panel.Controls.Add(this.inner_panel);
            this.outer_panel.Location = new System.Drawing.Point(0, 27);
            this.outer_panel.Name = "outer_panel";
            this.outer_panel.Size = new System.Drawing.Size(200, 423);
            this.outer_panel.TabIndex = 1;
            // 
            // main_tree
            // 
            this.main_tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.main_tree.Location = new System.Drawing.Point(-1, 34);
            this.main_tree.Name = "main_tree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Student Roster";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Syllabus";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Page1";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Page2";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Class1";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Student Roster";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Syllabus";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Page1";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Page2";
            treeNode10.Name = "Node5";
            treeNode10.Text = "Class2";
            this.main_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.main_tree.Size = new System.Drawing.Size(200, 388);
            this.main_tree.TabIndex = 2;
            // 
            // inner_panel
            // 
            this.inner_panel.BackColor = System.Drawing.Color.White;
            this.inner_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inner_panel.Controls.Add(this.classes_label);
            this.inner_panel.Location = new System.Drawing.Point(-1, -1);
            this.inner_panel.Name = "inner_panel";
            this.inner_panel.Size = new System.Drawing.Size(200, 29);
            this.inner_panel.TabIndex = 1;
            // 
            // classes_label
            // 
            this.classes_label.AutoSize = true;
            this.classes_label.Location = new System.Drawing.Point(68, 6);
            this.classes_label.Name = "classes_label";
            this.classes_label.Size = new System.Drawing.Size(65, 15);
            this.classes_label.TabIndex = 0;
            this.classes_label.Text = "My Classes";
            // 
            // right_panel
            // 
            this.right_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.right_panel.Location = new System.Drawing.Point(206, 27);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(594, 423);
            this.right_panel.TabIndex = 2;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.outer_panel);
            this.Controls.Add(this.main_menu);
            this.Name = "main_form";
            this.Text = "Canvas Hub";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.outer_panel.ResumeLayout(false);
            this.inner_panel.ResumeLayout(false);
            this.inner_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.Panel outer_panel;
        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.Panel inner_panel;
        private System.Windows.Forms.Panel right_panel;
        private System.Windows.Forms.TreeView main_tree;
    }
}

