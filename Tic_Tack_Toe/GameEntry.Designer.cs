namespace Tic_Tack_Toe
{
    partial class GameEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEntry));
            this.btnVSHuman = new System.Windows.Forms.Button();
            this.btnVSComputer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGamePlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVSHuman
            // 
            this.btnVSHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVSHuman.BackColor = System.Drawing.Color.Transparent;
            this.btnVSHuman.FlatAppearance.BorderSize = 0;
            this.btnVSHuman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVSHuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVSHuman.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVSHuman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVSHuman.Location = new System.Drawing.Point(0, 139);
            this.btnVSHuman.Name = "btnVSHuman";
            this.btnVSHuman.Size = new System.Drawing.Size(301, 45);
            this.btnVSHuman.TabIndex = 0;
            this.btnVSHuman.TabStop = false;
            this.btnVSHuman.Text = "Vs Human";
            this.btnVSHuman.UseVisualStyleBackColor = false;
            this.btnVSHuman.Click += new System.EventHandler(this.ButtonVsPlayerClicked);
            // 
            // btnVSComputer
            // 
            this.btnVSComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVSComputer.BackColor = System.Drawing.Color.Transparent;
            this.btnVSComputer.FlatAppearance.BorderSize = 0;
            this.btnVSComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnVSComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVSComputer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVSComputer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVSComputer.Location = new System.Drawing.Point(0, 190);
            this.btnVSComputer.Name = "btnVSComputer";
            this.btnVSComputer.Size = new System.Drawing.Size(301, 41);
            this.btnVSComputer.TabIndex = 1;
            this.btnVSComputer.TabStop = false;
            this.btnVSComputer.Text = "Vs Computer";
            this.btnVSComputer.UseVisualStyleBackColor = false;
            this.btnVSComputer.Click += new System.EventHandler(this.ButtonVsComputerClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(0, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(301, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ButtonExitClicked);
            // 
            // lblGamePlay
            // 
            this.lblGamePlay.AutoSize = true;
            this.lblGamePlay.BackColor = System.Drawing.Color.Transparent;
            this.lblGamePlay.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGamePlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGamePlay.Location = new System.Drawing.Point(12, 90);
            this.lblGamePlay.Name = "lblGamePlay";
            this.lblGamePlay.Size = new System.Drawing.Size(155, 25);
            this.lblGamePlay.TabIndex = 3;
            this.lblGamePlay.Text = "Select gameplay: ";
            this.lblGamePlay.UseMnemonic = false;
            // 
            // GameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tack_Toe.Properties.Resources.bg_ttt;
            this.ClientSize = new System.Drawing.Size(301, 341);
            this.Controls.Add(this.lblGamePlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVSComputer);
            this.Controls.Add(this.btnVSHuman);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVSHuman;
        private System.Windows.Forms.Button btnVSComputer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGamePlay;
    }
}