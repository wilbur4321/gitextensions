﻿using GitUI.Editor;

namespace GitUI.HelperDialogs
{
    partial class FormEdit
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
            this.Viewer = new GitUI.Editor.FileViewer();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(733, 571);
            this.Viewer.TabIndex = 0;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(733, 571);
            this.Controls.Add(this.Viewer);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private FileViewer Viewer;
    }
}