﻿namespace ZincBrowser
{
    partial class TabHandle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main = new Siticone.UI.WinForms.SiticoneButton();
            this.cls = new Siticone.UI.WinForms.SiticoneButton();
            this.favicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.favicon)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.main.BorderRadius = 10;
            this.main.BorderThickness = 1;
            this.main.CheckedState.Parent = this.main;
            this.main.CustomImages.Parent = this.main;
            this.main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main.ForeColor = System.Drawing.Color.White;
            this.main.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.main.HoveredState.Parent = this.main;
            this.main.Location = new System.Drawing.Point(3, 3);
            this.main.Name = "main";
            this.main.ShadowDecoration.Parent = this.main;
            this.main.Size = new System.Drawing.Size(297, 54);
            this.main.TabIndex = 0;
            this.main.Text = "Tab";
            this.main.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.main.TextOffset = new System.Drawing.Point(25, 0);
            this.main.Click += new System.EventHandler(this.TabHandle_Click);
            // 
            // cls
            // 
            this.cls.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cls.BorderRadius = 10;
            this.cls.BorderThickness = 1;
            this.cls.CheckedState.Parent = this.cls;
            this.cls.CustomImages.Parent = this.cls;
            this.cls.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cls.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cls.ForeColor = System.Drawing.Color.White;
            this.cls.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.cls.HoveredState.Parent = this.cls;
            this.cls.Image = global::ZincBrowser.Properties.Resources.x;
            this.cls.Location = new System.Drawing.Point(306, 3);
            this.cls.Name = "cls";
            this.cls.ShadowDecoration.Parent = this.cls;
            this.cls.Size = new System.Drawing.Size(54, 54);
            this.cls.TabIndex = 2;
            this.cls.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cls.TextOffset = new System.Drawing.Point(25, 0);
            this.cls.Click += new System.EventHandler(this.close_Click);
            // 
            // favicon
            // 
            this.favicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favicon.Location = new System.Drawing.Point(10, 10);
            this.favicon.Name = "favicon";
            this.favicon.Size = new System.Drawing.Size(40, 40);
            this.favicon.TabIndex = 1;
            this.favicon.TabStop = false;
            // 
            // TabHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cls);
            this.Controls.Add(this.favicon);
            this.Controls.Add(this.main);
            this.Name = "TabHandle";
            this.Size = new System.Drawing.Size(370, 60);
            this.Load += new System.EventHandler(this.TabHandle_Load);
            this.Click += new System.EventHandler(this.TabHandle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.favicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox favicon;
        private Siticone.UI.WinForms.SiticoneButton cls;
        public Siticone.UI.WinForms.SiticoneButton main;
    }
}
