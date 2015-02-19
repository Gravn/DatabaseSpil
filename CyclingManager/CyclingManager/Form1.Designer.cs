namespace CyclingManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.NewGame = new System.Windows.Forms.Button();
            this.NewNameInput = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.HoldNavnLabel = new System.Windows.Forms.Label();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.LoadGame = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.ComboBox();
            this.LoadLabel = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticker
            // 
            this.ticker.Enabled = true;
            this.ticker.Interval = 1;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick_1);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(76, 116);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Start nyt spil";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // NewNameInput
            // 
            this.NewNameInput.Location = new System.Drawing.Point(12, 74);
            this.NewNameInput.Name = "NewNameInput";
            this.NewNameInput.Size = new System.Drawing.Size(219, 20);
            this.NewNameInput.TabIndex = 1;
            this.NewNameInput.TextChanged += new System.EventHandler(this.NewNameInput_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(339, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(113, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Cycling Manager 2015";
            // 
            // HoldNavnLabel
            // 
            this.HoldNavnLabel.Location = new System.Drawing.Point(0, 0);
            this.HoldNavnLabel.Name = "HoldNavnLabel";
            this.HoldNavnLabel.Size = new System.Drawing.Size(100, 23);
            this.HoldNavnLabel.TabIndex = 0;
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Location = new System.Drawing.Point(93, 41);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(58, 13);
            this.NavnLabel.TabIndex = 3;
            this.NavnLabel.Text = "HoldNavn:";
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(569, 116);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(75, 23);
            this.LoadGame.TabIndex = 4;
            this.LoadGame.Text = "Fortsæt spil";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // LoadList
            // 
            this.LoadList.FormattingEnabled = true;
            this.LoadList.Items.AddRange(new object[] {
            "EasyOn",
            "Holdet der aldrig vinder ;(",
            "Rotary"});
            this.LoadList.Location = new System.Drawing.Point(568, 74);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(121, 21);
            this.LoadList.TabIndex = 5;
            // 
            // LoadLabel
            // 
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.Location = new System.Drawing.Point(565, 41);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(79, 13);
            this.LoadLabel.TabIndex = 6;
            this.LoadLabel.Text = "Vælg gemt spil:";
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(358, 505);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(75, 23);
            this.MenuBtn.TabIndex = 7;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.LoadLabel);
            this.Controls.Add(this.LoadList);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.NavnLabel);
            this.Controls.Add(this.HoldNavnLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NewNameInput);
            this.Controls.Add(this.NewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.TextBox NewNameInput;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label HoldNavnLabel;
        private System.Windows.Forms.Label NavnLabel;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.ComboBox LoadList;
        private System.Windows.Forms.Label LoadLabel;
        private System.Windows.Forms.Button MenuBtn;
    }
}

