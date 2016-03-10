namespace Tic_Tack_Toe
{
    partial class MultiPlayerUserSetUpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiPlayerUserSetUpView));
            this.LblFirstPlayer = new System.Windows.Forms.Label();
            this.lblSecondPlayer = new System.Windows.Forms.Label();
            this.comboBoxFirstPlayerSymbol = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.comboBoxSecondPlayerSymbol = new System.Windows.Forms.ComboBox();
            this.txtFirstPlayerName = new System.Windows.Forms.TextBox();
            this.txtSecondPlayerName = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirstSymbolErr = new System.Windows.Forms.Label();
            this.lblSecondSymbolErr = new System.Windows.Forms.Label();
            this.llbFirstPlayerNameErr = new System.Windows.Forms.Label();
            this.lblSecondPlayerNameErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFirstPlayer
            // 
            this.LblFirstPlayer.AutoSize = true;
            this.LblFirstPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 14.2F, System.Drawing.FontStyle.Bold);
            this.LblFirstPlayer.Location = new System.Drawing.Point(7, 9);
            this.LblFirstPlayer.Name = "LblFirstPlayer";
            this.LblFirstPlayer.Size = new System.Drawing.Size(183, 22);
            this.LblFirstPlayer.TabIndex = 0;
            this.LblFirstPlayer.Text = "Enter player 1 name:  \r\n";
            // 
            // lblSecondPlayer
            // 
            this.lblSecondPlayer.AutoSize = true;
            this.lblSecondPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblSecondPlayer.Location = new System.Drawing.Point(7, 157);
            this.lblSecondPlayer.Name = "lblSecondPlayer";
            this.lblSecondPlayer.Size = new System.Drawing.Size(183, 22);
            this.lblSecondPlayer.TabIndex = 1;
            this.lblSecondPlayer.Text = "Enter player 2 name:  \r\n";
            // 
            // comboBoxFirstPlayerSymbol
            // 
            this.comboBoxFirstPlayerSymbol.Font = new System.Drawing.Font("Monotype Corsiva", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFirstPlayerSymbol.FormattingEnabled = true;
            this.comboBoxFirstPlayerSymbol.Location = new System.Drawing.Point(104, 92);
            this.comboBoxFirstPlayerSymbol.Name = "comboBoxFirstPlayerSymbol";
            this.comboBoxFirstPlayerSymbol.Size = new System.Drawing.Size(164, 30);
            this.comboBoxFirstPlayerSymbol.TabIndex = 2;
            this.comboBoxFirstPlayerSymbol.TabStop = false;
            this.comboBoxFirstPlayerSymbol.Text = "Choose symbol";
            this.comboBoxFirstPlayerSymbol.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFirstPlayerSymbolSelectedIndexChanged);
            this.comboBoxFirstPlayerSymbol.Click += new System.EventHandler(this.ComboBoxFirstPlayerSymbolClicked);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(80, 299);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(141, 43);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.ButtonPlayClicked);
            // 
            // comboBoxSecondPlayerSymbol
            // 
            this.comboBoxSecondPlayerSymbol.Font = new System.Drawing.Font("Monotype Corsiva", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSecondPlayerSymbol.FormattingEnabled = true;
            this.comboBoxSecondPlayerSymbol.Location = new System.Drawing.Point(104, 240);
            this.comboBoxSecondPlayerSymbol.Name = "comboBoxSecondPlayerSymbol";
            this.comboBoxSecondPlayerSymbol.Size = new System.Drawing.Size(164, 30);
            this.comboBoxSecondPlayerSymbol.TabIndex = 5;
            this.comboBoxSecondPlayerSymbol.TabStop = false;
            this.comboBoxSecondPlayerSymbol.Text = "Choose symbol";
            this.comboBoxSecondPlayerSymbol.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSecondPlayerSymbolSelectedIndexChanged);
            this.comboBoxSecondPlayerSymbol.Click += new System.EventHandler(this.ComboBoxSecondPlayerSymbolClicked);
            // 
            // txtFirstPlayerName
            // 
            this.txtFirstPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstPlayerName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstPlayerName.Location = new System.Drawing.Point(104, 47);
            this.txtFirstPlayerName.Multiline = true;
            this.txtFirstPlayerName.Name = "txtFirstPlayerName";
            this.txtFirstPlayerName.Size = new System.Drawing.Size(185, 25);
            this.txtFirstPlayerName.TabIndex = 6;
            this.txtFirstPlayerName.TextChanged += new System.EventHandler(this.ТxtFirstPlayerNameTextChanged);
            // 
            // txtSecondPlayerName
            // 
            this.txtSecondPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecondPlayerName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondPlayerName.Location = new System.Drawing.Point(104, 196);
            this.txtSecondPlayerName.Multiline = true;
            this.txtSecondPlayerName.Name = "txtSecondPlayerName";
            this.txtSecondPlayerName.Size = new System.Drawing.Size(185, 24);
            this.txtSecondPlayerName.TabIndex = 7;
            this.txtSecondPlayerName.TextChanged += new System.EventHandler(this.ТxtSecondPlayerNameTextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(220, 299);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(79, 43);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.ButtonExitClicked);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(-1, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 43);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.ButtonBackClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(411, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 10;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 11;
            this.label4.Visible = false;
            // 
            // lblFirstSymbolErr
            // 
            this.lblFirstSymbolErr.AutoSize = true;
            this.lblFirstSymbolErr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblFirstSymbolErr.ForeColor = System.Drawing.Color.Red;
            this.lblFirstSymbolErr.Location = new System.Drawing.Point(103, 125);
            this.lblFirstSymbolErr.Name = "lblFirstSymbolErr";
            this.lblFirstSymbolErr.Size = new System.Drawing.Size(132, 14);
            this.lblFirstSymbolErr.TabIndex = 12;
            this.lblFirstSymbolErr.Text = "Please choose symbol";
            // 
            // lblSecondSymbolErr
            // 
            this.lblSecondSymbolErr.AutoSize = true;
            this.lblSecondSymbolErr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblSecondSymbolErr.ForeColor = System.Drawing.Color.Red;
            this.lblSecondSymbolErr.Location = new System.Drawing.Point(103, 273);
            this.lblSecondSymbolErr.Name = "lblSecondSymbolErr";
            this.lblSecondSymbolErr.Size = new System.Drawing.Size(132, 14);
            this.lblSecondSymbolErr.TabIndex = 13;
            this.lblSecondSymbolErr.Text = "Please choose symbol";
            // 
            // llbFirstPlayerNameErr
            // 
            this.llbFirstPlayerNameErr.AutoSize = true;
            this.llbFirstPlayerNameErr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.llbFirstPlayerNameErr.ForeColor = System.Drawing.Color.Red;
            this.llbFirstPlayerNameErr.Location = new System.Drawing.Point(103, 75);
            this.llbFirstPlayerNameErr.Name = "llbFirstPlayerNameErr";
            this.llbFirstPlayerNameErr.Size = new System.Drawing.Size(148, 14);
            this.llbFirstPlayerNameErr.TabIndex = 14;
            this.llbFirstPlayerNameErr.Text = "Please enter a valid name";
            // 
            // lblSecondPlayerNameErr
            // 
            this.lblSecondPlayerNameErr.AutoSize = true;
            this.lblSecondPlayerNameErr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblSecondPlayerNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblSecondPlayerNameErr.Location = new System.Drawing.Point(103, 223);
            this.lblSecondPlayerNameErr.Name = "lblSecondPlayerNameErr";
            this.lblSecondPlayerNameErr.Size = new System.Drawing.Size(148, 14);
            this.lblSecondPlayerNameErr.TabIndex = 15;
            this.lblSecondPlayerNameErr.Text = "Please enter a valid name";
            // 
            // MultiPlayerUserSetUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Tic_Tack_Toe.Properties.Resources.bg_ttt1;
            this.ClientSize = new System.Drawing.Size(301, 341);
            this.Controls.Add(this.lblSecondPlayerNameErr);
            this.Controls.Add(this.llbFirstPlayerNameErr);
            this.Controls.Add(this.lblSecondSymbolErr);
            this.Controls.Add(this.lblFirstSymbolErr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.txtSecondPlayerName);
            this.Controls.Add(this.txtFirstPlayerName);
            this.Controls.Add(this.comboBoxSecondPlayerSymbol);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.comboBoxFirstPlayerSymbol);
            this.Controls.Add(this.lblSecondPlayer);
            this.Controls.Add(this.LblFirstPlayer);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MultiPlayerUserSetUpView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player SetUp";
            this.Load += new System.EventHandler(this.MultiPlayerUserSetUpViewLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstPlayer;
        private System.Windows.Forms.Label lblSecondPlayer;
        private System.Windows.Forms.ComboBox comboBoxFirstPlayerSymbol;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox comboBoxSecondPlayerSymbol;
        private System.Windows.Forms.TextBox txtFirstPlayerName;
        private System.Windows.Forms.TextBox txtSecondPlayerName;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFirstSymbolErr;
        private System.Windows.Forms.Label lblSecondSymbolErr;
        private System.Windows.Forms.Label llbFirstPlayerNameErr;
        private System.Windows.Forms.Label lblSecondPlayerNameErr;
    }
}