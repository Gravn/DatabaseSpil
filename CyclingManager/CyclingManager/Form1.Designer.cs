﻿namespace CyclingManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeleteSave = new System.Windows.Forms.Button();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteHelp = new System.Windows.Forms.Label();
            this.Exists = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 100);
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
            this.LoadGame.Location = new System.Drawing.Point(569, 101);
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
            this.LoadList.Location = new System.Drawing.Point(568, 74);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(121, 21);
            this.LoadList.TabIndex = 5;
            this.LoadList.SelectedIndexChanged += new System.EventHandler(this.LoadList_SelectedIndexChanged);
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
            this.MenuBtn.Location = new System.Drawing.Point(368, 527);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(75, 23);
            this.MenuBtn.TabIndex = 7;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(440, 278);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(455, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(317, 278);
            this.dataGridView2.TabIndex = 9;
            // 
            // DeleteSave
            // 
            this.DeleteSave.Location = new System.Drawing.Point(12, 190);
            this.DeleteSave.Name = "DeleteSave";
            this.DeleteSave.Size = new System.Drawing.Size(75, 23);
            this.DeleteSave.TabIndex = 10;
            this.DeleteSave.Text = "Slet Spil";
            this.DeleteSave.UseVisualStyleBackColor = true;
            this.DeleteSave.Click += new System.EventHandler(this.DeleteSave_Click);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(12, 164);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(219, 20);
            this.deleteTextBox.TabIndex = 11;
            // 
            // DeleteHelp
            // 
            this.DeleteHelp.AutoSize = true;
            this.DeleteHelp.Location = new System.Drawing.Point(12, 148);
            this.DeleteHelp.Name = "DeleteHelp";
            this.DeleteHelp.Size = new System.Drawing.Size(183, 13);
            this.DeleteHelp.TabIndex = 12;
            this.DeleteHelp.Text = "Indtast navn på spillet der skal slettes";
            // 
            // Exists
            // 
            this.Exists.AutoEllipsis = true;
            this.Exists.AutoSize = true;
            this.Exists.Enabled = false;
            this.Exists.Location = new System.Drawing.Point(93, 106);
            this.Exists.Name = "Exists";
            this.Exists.Size = new System.Drawing.Size(81, 13);
            this.Exists.TabIndex = 13;
            this.Exists.Text = "Findes allerede!";
            this.Exists.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Exists);
            this.Controls.Add(this.DeleteHelp);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.DeleteSave);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeleteSave;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Label DeleteHelp;
        private System.Windows.Forms.Label Exists;
    }
}

