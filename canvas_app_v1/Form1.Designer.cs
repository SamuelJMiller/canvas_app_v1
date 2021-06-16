
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
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.outer_panel = new System.Windows.Forms.Panel();
            this.new_page_button = new System.Windows.Forms.Button();
            this.main_tree = new canvas_app_v1.NativeTreeView();
            this.inner_panel = new System.Windows.Forms.Panel();
            this.classes_label = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.tut_label_bottom_2 = new System.Windows.Forms.Label();
            this.tut_label_bottom_1 = new System.Windows.Forms.Label();
            this.tut_label_top = new System.Windows.Forms.Label();
            this.file_in = new System.Windows.Forms.Button();
            this.outer_panel.SuspendLayout();
            this.inner_panel.SuspendLayout();
            this.right_panel.SuspendLayout();
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
            this.outer_panel.Controls.Add(this.new_page_button);
            this.outer_panel.Controls.Add(this.main_tree);
            this.outer_panel.Controls.Add(this.inner_panel);
            this.outer_panel.Location = new System.Drawing.Point(0, 27);
            this.outer_panel.Name = "outer_panel";
            this.outer_panel.Size = new System.Drawing.Size(200, 423);
            this.outer_panel.TabIndex = 1;
            // 
            // new_page_button
            // 
            this.new_page_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.new_page_button.Location = new System.Drawing.Point(49, 363);
            this.new_page_button.Name = "new_page_button";
            this.new_page_button.Size = new System.Drawing.Size(102, 23);
            this.new_page_button.TabIndex = 3;
            this.new_page_button.Text = "New Page";
            this.new_page_button.UseVisualStyleBackColor = true;
            this.new_page_button.Click += new System.EventHandler(this.new_page_button_Click);
            // 
            // main_tree
            // 
            this.main_tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.main_tree.Location = new System.Drawing.Point(-1, 34);
            this.main_tree.Name = "main_tree";
            this.main_tree.Size = new System.Drawing.Size(200, 388);
            this.main_tree.TabIndex = 2;
            this.main_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.main_tree_AfterSelect);
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
            this.right_panel.Controls.Add(this.tut_label_bottom_2);
            this.right_panel.Controls.Add(this.tut_label_bottom_1);
            this.right_panel.Controls.Add(this.tut_label_top);
            this.right_panel.Location = new System.Drawing.Point(206, 27);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(594, 423);
            this.right_panel.TabIndex = 2;
            // 
            // tut_label_bottom_2
            // 
            this.tut_label_bottom_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tut_label_bottom_2.AutoSize = true;
            this.tut_label_bottom_2.Location = new System.Drawing.Point(171, 146);
            this.tut_label_bottom_2.Name = "tut_label_bottom_2";
            this.tut_label_bottom_2.Size = new System.Drawing.Size(252, 15);
            this.tut_label_bottom_2.TabIndex = 3;
            this.tut_label_bottom_2.Text = "click the \"New Page\" button in the bottom left";
            // 
            // tut_label_bottom_1
            // 
            this.tut_label_bottom_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tut_label_bottom_1.AutoSize = true;
            this.tut_label_bottom_1.Location = new System.Drawing.Point(142, 131);
            this.tut_label_bottom_1.Name = "tut_label_bottom_1";
            this.tut_label_bottom_1.Size = new System.Drawing.Size(310, 15);
            this.tut_label_bottom_1.TabIndex = 2;
            this.tut_label_bottom_1.Text = "To create a new page for a class, select the class, and then";
            // 
            // tut_label_top
            // 
            this.tut_label_top.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tut_label_top.AutoSize = true;
            this.tut_label_top.Location = new System.Drawing.Point(205, 13);
            this.tut_label_top.Name = "tut_label_top";
            this.tut_label_top.Size = new System.Drawing.Size(184, 15);
            this.tut_label_top.TabIndex = 0;
            this.tut_label_top.Text = "Select a class page to start editing";
            // 
            // file_in
            // 
            this.file_in.Location = new System.Drawing.Point(0, 0);
            this.file_in.Name = "file_in";
            this.file_in.Size = new System.Drawing.Size(75, 23);
            this.file_in.TabIndex = 0;
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
            this.Text = "Canvas Desktop";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.outer_panel.ResumeLayout(false);
            this.inner_panel.ResumeLayout(false);
            this.inner_panel.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.right_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.Panel outer_panel;
        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.Panel inner_panel;
        private System.Windows.Forms.Panel right_panel;
        private NativeTreeView main_tree;
        private System.Windows.Forms.Button new_page_button;
        private System.Windows.Forms.Label tut_label_top;
        private System.Windows.Forms.Label tut_label_bottom_1;
        private System.Windows.Forms.Label tut_label_bottom_2;
        private System.Windows.Forms.Button file_in;
    }
}

