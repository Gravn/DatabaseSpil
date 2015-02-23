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
            this.NewGame = new System.Windows.Forms.Button();
            this.NewNameInput = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.HoldNavnLabel = new System.Windows.Forms.Label();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.LoadGame = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.ComboBox();
            this.LoadLabel = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeleteSave = new System.Windows.Forms.Button();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteHelp = new System.Windows.Forms.Label();
            this.Exists = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.comboBoxKøbTræner6 = new System.Windows.Forms.ComboBox();
            this.comboBoxKøbTræner5 = new System.Windows.Forms.ComboBox();
            this.textBoxKøbTræner2 = new System.Windows.Forms.TextBox();
            this.comboBoxKøbTræner4 = new System.Windows.Forms.ComboBox();
            this.checkBoxKøbTræner1 = new System.Windows.Forms.CheckBox();
            this.buttonSøgTræner = new System.Windows.Forms.Button();
            this.textBoxKøbTræner1 = new System.Windows.Forms.TextBox();
            this.comboBoxKøbTræner2 = new System.Windows.Forms.ComboBox();
            this.comboBoxKøbTræner3 = new System.Windows.Forms.ComboBox();
            this.comboBoxKøbTræner1 = new System.Windows.Forms.ComboBox();
            this.dataGridTræner = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTræner)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(16, 123);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(100, 28);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Start nyt spil";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // NewNameInput
            // 
            this.NewNameInput.Location = new System.Drawing.Point(16, 91);
            this.NewNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.NewNameInput.Name = "NewNameInput";
            this.NewNameInput.Size = new System.Drawing.Size(291, 22);
            this.NewNameInput.TabIndex = 1;
            this.NewNameInput.TextChanged += new System.EventHandler(this.NewNameInput_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(452, 12);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(149, 17);
            this.Title.TabIndex = 2;
            this.Title.Text = "Cycling Manager 2015";
            // 
            // HoldNavnLabel
            // 
            this.HoldNavnLabel.Location = new System.Drawing.Point(0, 0);
            this.HoldNavnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoldNavnLabel.Name = "HoldNavnLabel";
            this.HoldNavnLabel.Size = new System.Drawing.Size(133, 28);
            this.HoldNavnLabel.TabIndex = 0;
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Location = new System.Drawing.Point(124, 50);
            this.NavnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(74, 17);
            this.NavnLabel.TabIndex = 3;
            this.NavnLabel.Text = "HoldNavn:";
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(759, 124);
            this.LoadGame.Margin = new System.Windows.Forms.Padding(4);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(100, 28);
            this.LoadGame.TabIndex = 4;
            this.LoadGame.Text = "Fortsæt spil";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // LoadList
            // 
            this.LoadList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoadList.FormattingEnabled = true;
            this.LoadList.Location = new System.Drawing.Point(757, 91);
            this.LoadList.Margin = new System.Windows.Forms.Padding(4);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(160, 24);
            this.LoadList.Sorted = true;
            this.LoadList.TabIndex = 5;
            // 
            // LoadLabel
            // 
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.Location = new System.Drawing.Point(753, 50);
            this.LoadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(105, 17);
            this.LoadLabel.TabIndex = 6;
            this.LoadLabel.Text = "Vælg gemt spil:";
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(929, 15);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(100, 28);
            this.MenuBtn.TabIndex = 7;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1023, 602);
            this.dataGridView2.TabIndex = 9;
            // 
            // DeleteSave
            // 
            this.DeleteSave.Location = new System.Drawing.Point(16, 234);
            this.DeleteSave.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSave.Name = "DeleteSave";
            this.DeleteSave.Size = new System.Drawing.Size(100, 28);
            this.DeleteSave.TabIndex = 10;
            this.DeleteSave.Text = "Slet Spil";
            this.DeleteSave.UseVisualStyleBackColor = true;
            this.DeleteSave.Click += new System.EventHandler(this.DeleteSave_Click);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(16, 202);
            this.deleteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(291, 22);
            this.deleteTextBox.TabIndex = 11;
            // 
            // DeleteHelp
            // 
            this.DeleteHelp.AutoSize = true;
            this.DeleteHelp.Location = new System.Drawing.Point(16, 182);
            this.DeleteHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteHelp.Name = "DeleteHelp";
            this.DeleteHelp.Size = new System.Drawing.Size(244, 17);
            this.DeleteHelp.TabIndex = 12;
            this.DeleteHelp.Text = "Indtast navn på spillet der skal slettes";
            // 
            // Exists
            // 
            this.Exists.AutoEllipsis = true;
            this.Exists.AutoSize = true;
            this.Exists.Enabled = false;
            this.Exists.Location = new System.Drawing.Point(124, 130);
            this.Exists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exists.Name = "Exists";
            this.Exists.Size = new System.Drawing.Size(108, 17);
            this.Exists.TabIndex = 13;
            this.Exists.Text = "Findes allerede!";
            this.Exists.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(4, 50);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1041, 641);
            this.tabControl.TabIndex = 14;
            this.tabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1033, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mine Ryttere";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 514);
            this.dataGridView1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1033, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Budget";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1033, 612);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Divison";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1033, 612);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transfer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 610);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1019, 581);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Køb Rytter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(1019, 581);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Sælg Rytter";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.comboBoxKøbTræner6);
            this.tabPage7.Controls.Add(this.comboBoxKøbTræner5);
            this.tabPage7.Controls.Add(this.textBoxKøbTræner2);
            this.tabPage7.Controls.Add(this.comboBoxKøbTræner4);
            this.tabPage7.Controls.Add(this.checkBoxKøbTræner1);
            this.tabPage7.Controls.Add(this.buttonSøgTræner);
            this.tabPage7.Controls.Add(this.textBoxKøbTræner1);
            this.tabPage7.Controls.Add(this.comboBoxKøbTræner2);
            this.tabPage7.Controls.Add(this.comboBoxKøbTræner3);
            this.tabPage7.Controls.Add(this.comboBoxKøbTræner1);
            this.tabPage7.Controls.Add(this.dataGridTræner);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1019, 581);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Køb Træner";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // comboBoxKøbTræner6
            // 
            this.comboBoxKøbTræner6.FormattingEnabled = true;
            this.comboBoxKøbTræner6.Items.AddRange(new object[] {
            "LIKE",
            "NOT LIKE"});
            this.comboBoxKøbTræner6.Location = new System.Drawing.Point(43, 383);
            this.comboBoxKøbTræner6.Name = "comboBoxKøbTræner6";
            this.comboBoxKøbTræner6.Size = new System.Drawing.Size(111, 24);
            this.comboBoxKøbTræner6.TabIndex = 10;
            this.comboBoxKøbTræner6.Visible = false;
            // 
            // comboBoxKøbTræner5
            // 
            this.comboBoxKøbTræner5.FormattingEnabled = true;
            this.comboBoxKøbTræner5.Items.AddRange(new object[] {
            "LIKE",
            "NOT LIKE"});
            this.comboBoxKøbTræner5.Location = new System.Drawing.Point(43, 117);
            this.comboBoxKøbTræner5.Name = "comboBoxKøbTræner5";
            this.comboBoxKøbTræner5.Size = new System.Drawing.Size(111, 24);
            this.comboBoxKøbTræner5.TabIndex = 9;
            this.comboBoxKøbTræner5.Visible = false;
            // 
            // textBoxKøbTræner2
            // 
            this.textBoxKøbTræner2.Location = new System.Drawing.Point(43, 424);
            this.textBoxKøbTræner2.Name = "textBoxKøbTræner2";
            this.textBoxKøbTræner2.Size = new System.Drawing.Size(111, 22);
            this.textBoxKøbTræner2.TabIndex = 8;
            // 
            // comboBoxKøbTræner4
            // 
            this.comboBoxKøbTræner4.FormattingEnabled = true;
            this.comboBoxKøbTræner4.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.comboBoxKøbTræner4.Location = new System.Drawing.Point(43, 383);
            this.comboBoxKøbTræner4.Name = "comboBoxKøbTræner4";
            this.comboBoxKøbTræner4.Size = new System.Drawing.Size(111, 24);
            this.comboBoxKøbTræner4.TabIndex = 7;
            // 
            // checkBoxKøbTræner1
            // 
            this.checkBoxKøbTræner1.AutoSize = true;
            this.checkBoxKøbTræner1.Location = new System.Drawing.Point(43, 295);
            this.checkBoxKøbTræner1.Name = "checkBoxKøbTræner1";
            this.checkBoxKøbTræner1.Size = new System.Drawing.Size(111, 21);
            this.checkBoxKøbTræner1.TabIndex = 6;
            this.checkBoxKøbTræner1.Text = "2. parameter";
            this.checkBoxKøbTræner1.UseVisualStyleBackColor = true;
            // 
            // buttonSøgTræner
            // 
            this.buttonSøgTræner.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSøgTræner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSøgTræner.Location = new System.Drawing.Point(43, 478);
            this.buttonSøgTræner.Name = "buttonSøgTræner";
            this.buttonSøgTræner.Size = new System.Drawing.Size(111, 33);
            this.buttonSøgTræner.TabIndex = 5;
            this.buttonSøgTræner.Text = "Søg";
            this.buttonSøgTræner.UseVisualStyleBackColor = false;
            this.buttonSøgTræner.Click += new System.EventHandler(this.buttonSøgTræner_Click);
            // 
            // textBoxKøbTræner1
            // 
            this.textBoxKøbTræner1.Location = new System.Drawing.Point(43, 165);
            this.textBoxKøbTræner1.Name = "textBoxKøbTræner1";
            this.textBoxKøbTræner1.Size = new System.Drawing.Size(111, 22);
            this.textBoxKøbTræner1.TabIndex = 4;
            // 
            // comboBoxKøbTræner2
            // 
            this.comboBoxKøbTræner2.FormattingEnabled = true;
            this.comboBoxKøbTræner2.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.comboBoxKøbTræner2.Location = new System.Drawing.Point(43, 117);
            this.comboBoxKøbTræner2.Name = "comboBoxKøbTræner2";
            this.comboBoxKøbTræner2.Size = new System.Drawing.Size(111, 24);
            this.comboBoxKøbTræner2.TabIndex = 3;
            // 
            // comboBoxKøbTræner3
            // 
            this.comboBoxKøbTræner3.FormattingEnabled = true;
            this.comboBoxKøbTræner3.Items.AddRange(new object[] {
            "ID",
            "Navn",
            "Fokus",
            "Erfaring",
            "Løn"});
            this.comboBoxKøbTræner3.Location = new System.Drawing.Point(43, 339);
            this.comboBoxKøbTræner3.Name = "comboBoxKøbTræner3";
            this.comboBoxKøbTræner3.Size = new System.Drawing.Size(111, 24);
            this.comboBoxKøbTræner3.TabIndex = 2;
            this.comboBoxKøbTræner3.SelectedIndexChanged += new System.EventHandler(this.comboBoxKøbTræner3_SelectedIndexChanged);
            // 
            // comboBoxKøbTræner1
            // 
            this.comboBoxKøbTræner1.FormattingEnabled = true;
            this.comboBoxKøbTræner1.Items.AddRange(new object[] {
            "ID",
            "Navn",
            "Fokus",
            "Erfaring",
            "Løn"});
            this.comboBoxKøbTræner1.Location = new System.Drawing.Point(43, 78);
            this.comboBoxKøbTræner1.Name = "comboBoxKøbTræner1";
            this.comboBoxKøbTræner1.Size = new System.Drawing.Size(111, 24);
            this.comboBoxKøbTræner1.TabIndex = 1;
            this.comboBoxKøbTræner1.SelectedIndexChanged += new System.EventHandler(this.comboBoxKøbTræner1_SelectedIndexChanged);
            // 
            // dataGridTræner
            // 
            this.dataGridTræner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTræner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTræner.Location = new System.Drawing.Point(292, 3);
            this.dataGridTræner.Name = "dataGridTræner";
            this.dataGridTræner.ReadOnly = true;
            this.dataGridTræner.RowTemplate.Height = 24;
            this.dataGridTræner.Size = new System.Drawing.Size(721, 577);
            this.dataGridTræner.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1019, 581);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Sælg Træner";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 692);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Exists);
            this.Controls.Add(this.DeleteHelp);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.DeleteSave);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.LoadLabel);
            this.Controls.Add(this.LoadList);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.NavnLabel);
            this.Controls.Add(this.HoldNavnLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NewNameInput);
            this.Controls.Add(this.NewGame);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTræner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.TextBox NewNameInput;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label HoldNavnLabel;
        private System.Windows.Forms.Label NavnLabel;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.ComboBox LoadList;
        private System.Windows.Forms.Label LoadLabel;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeleteSave;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Label DeleteHelp;
        private System.Windows.Forms.Label Exists;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox comboBoxKøbTræner1;
        private System.Windows.Forms.DataGridView dataGridTræner;
        private System.Windows.Forms.TextBox textBoxKøbTræner1;
        private System.Windows.Forms.ComboBox comboBoxKøbTræner2;
        private System.Windows.Forms.ComboBox comboBoxKøbTræner3;
        private System.Windows.Forms.CheckBox checkBoxKøbTræner1;
        private System.Windows.Forms.Button buttonSøgTræner;
        private System.Windows.Forms.ComboBox comboBoxKøbTræner4;
        private System.Windows.Forms.TextBox textBoxKøbTræner2;
        private System.Windows.Forms.ComboBox comboBoxKøbTræner5;
        private System.Windows.Forms.ComboBox comboBoxKøbTræner6;
    }
}

