
namespace canvas_app_v1
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_prompt_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(308, 248);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(200, 23);
            this.password_box.TabIndex = 0;
            this.password_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_box_KeyPress);
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(308, 166);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(200, 23);
            this.username_box.TabIndex = 1;
            this.username_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_box_KeyPress);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(377, 133);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(63, 15);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(378, 219);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(60, 15);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password:";
            // 
            // login_prompt_label
            // 
            this.login_prompt_label.AutoSize = true;
            this.login_prompt_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_prompt_label.ForeColor = System.Drawing.Color.White;
            this.login_prompt_label.Location = new System.Drawing.Point(293, 29);
            this.login_prompt_label.Name = "login_prompt_label";
            this.login_prompt_label.Size = new System.Drawing.Size(230, 15);
            this.login_prompt_label.TabIndex = 4;
            this.login_prompt_label.Text = "Please log in with your Canvas credentials:";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_prompt_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.password_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "login_form";
            this.Text = "Canvas Desktop Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label login_prompt_label;
    }
}