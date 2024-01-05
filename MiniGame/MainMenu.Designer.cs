namespace MiniGame
{
    partial class MainMenu
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.btn_GridGame = new System.Windows.Forms.Button();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.btn_GridGame);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(179, 745);
            this.panel_Left.TabIndex = 0;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(179, 645);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(676, 100);
            this.panel_Bottom.TabIndex = 1;
            // 
            // panel_Center
            // 
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Center.Location = new System.Drawing.Point(179, 0);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(676, 645);
            this.panel_Center.TabIndex = 2;
            // 
            // btn_GridGame
            // 
            this.btn_GridGame.Location = new System.Drawing.Point(12, 115);
            this.btn_GridGame.Name = "btn_GridGame";
            this.btn_GridGame.Size = new System.Drawing.Size(161, 23);
            this.btn_GridGame.TabIndex = 0;
            this.btn_GridGame.Text = "Grid Game";
            this.btn_GridGame.UseVisualStyleBackColor = true;
            this.btn_GridGame.Click += new System.EventHandler(this.btn_GridGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 745);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Left);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.Button btn_GridGame;
    }
}