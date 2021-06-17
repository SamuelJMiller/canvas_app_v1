
namespace canvas_app_v1
{
    partial class PageNameForm
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
            this.finish_button = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finish_button
            // 
            this.finish_button.Location = new System.Drawing.Point(42, 89);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(75, 23);
            this.finish_button.TabIndex = 1;
            this.finish_button.Text = "Finish";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(42, 41);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(300, 23);
            this.name_box.TabIndex = 0;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(267, 89);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // PageNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 151);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.finish_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PageNameForm";
            this.Text = "Configure Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Button cancel_button;
    }
}