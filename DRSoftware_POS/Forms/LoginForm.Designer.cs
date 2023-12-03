namespace DRSoftware_POS.Forms
{
    partial class LoginForm
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
            this.buttonDRSkin1 = new DRSkin_UI.Controls.ButtonDRSkin();
            this.SuspendLayout();
            // 
            // buttonDRSkin1
            // 
            this.buttonDRSkin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDRSkin1.Density = DRSkin_UI.Controls.ButtonDRSkin.MaterialButtonDensity.Default;
            this.buttonDRSkin1.Depth = 0;
            this.buttonDRSkin1.HighEmphasis = true;
            this.buttonDRSkin1.Icon = null;
            this.buttonDRSkin1.Location = new System.Drawing.Point(215, 177);
            this.buttonDRSkin1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDRSkin1.MouseState = DRSkin_UI.MouseState.HOVER;
            this.buttonDRSkin1.Name = "buttonDRSkin1";
            this.buttonDRSkin1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDRSkin1.Size = new System.Drawing.Size(139, 36);
            this.buttonDRSkin1.TabIndex = 0;
            this.buttonDRSkin1.Text = "buttonDRSkin1";
            this.buttonDRSkin1.Type = DRSkin_UI.Controls.ButtonDRSkin.MaterialButtonType.Contained;
            this.buttonDRSkin1.UseAccentColor = false;
            this.buttonDRSkin1.UseVisualStyleBackColor = true;
            this.buttonDRSkin1.Click += new System.EventHandler(this.buttonDRSkin1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.buttonDRSkin1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DRSkin_UI.Controls.ButtonDRSkin buttonDRSkin1;
    }
}