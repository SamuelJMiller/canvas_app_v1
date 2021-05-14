
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
            this.main_split = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.main_split)).BeginInit();
            this.main_split.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_split
            // 
            this.main_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_split.Location = new System.Drawing.Point(0, 0);
            this.main_split.Name = "main_split";
            this.main_split.Size = new System.Drawing.Size(800, 450);
            this.main_split.SplitterDistance = 266;
            this.main_split.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_split);
            this.Name = "main_form";
            this.Text = "Canvas Hub";
            ((System.ComponentModel.ISupportInitialize)(this.main_split)).EndInit();
            this.main_split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer main_split;
    }
}

