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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OverSkrift = new System.Windows.Forms.Label();
            this.HoldNavnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadGame = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.NewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            // 
            // OverSkrift
            // 
            this.OverSkrift.AutoSize = true;
            this.OverSkrift.Location = new System.Drawing.Point(339, 10);
            this.OverSkrift.Name = "OverSkrift";
            this.OverSkrift.Size = new System.Drawing.Size(113, 13);
            this.OverSkrift.TabIndex = 2;
            this.OverSkrift.Text = "Cycling Manager 2015";
            // 
            // HoldNavnLabel
            // 
            this.HoldNavnLabel.Location = new System.Drawing.Point(0, 0);
            this.HoldNavnLabel.Name = "HoldNavnLabel";
            this.HoldNavnLabel.Size = new System.Drawing.Size(100, 23);
            this.HoldNavnLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HoldNavn:";
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(569, 116);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(75, 23);
            this.LoadGame.TabIndex = 4;
            this.LoadGame.Text = "Fortsæt spil";
            this.LoadGame.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EasyOn",
            "Holdet der aldrig vinder ;(",
            "Rotary"});
            this.comboBox1.Location = new System.Drawing.Point(568, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vælg gemt spil:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoldNavnLabel);
            this.Controls.Add(this.OverSkrift);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OverSkrift;
        private System.Windows.Forms.Label HoldNavnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

