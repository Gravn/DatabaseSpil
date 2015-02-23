using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CyclingManager
{
    public partial class Form1 : Form
    {
        //string to send to sqlite as command
        public static string dbname;

        //databases saved in /saves.
        public static string[] saves;

        //current location path
        string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static SQLiteConnection dbConnection;
        SQLiteCommand cmd = new SQLiteCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuBtn.Visible = false;
            MenuBtn.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;


            AddtoLoadList();

        }

        private void AddtoLoadList()
        {
            //Checks for .db files and adds the names onto the dropdown load list.
            saves = System.IO.Directory.GetFiles(@"saves\", "*.db");
            foreach (string s in saves)
            {
                string[] splitS = s.Split('\\', '.');

                if (LoadList.Items.Contains(splitS[1]) == false)
                {
                    LoadList.Items.Add(splitS[1]);
                }
            }
        }

        private void ToggleUI()
        {
            //hide start suff
            Title.Enabled = !Title.Enabled;
            Title.Visible = !Title.Visible;

            NavnLabel.Enabled = !NavnLabel.Enabled;
            NavnLabel.Visible = !NavnLabel.Visible;

            NewNameInput.Enabled = !NewNameInput.Enabled;
            NewNameInput.Visible = !NewNameInput.Visible;

            NewGame.Enabled = !NewGame.Enabled;
            NewGame.Visible = !NewGame.Visible;

            LoadLabel.Enabled = !LoadLabel.Enabled;
            LoadLabel.Visible = !LoadLabel.Visible;

            LoadList.Enabled = !LoadList.Enabled;
            LoadList.Visible = !LoadList.Visible;

            LoadGame.Enabled = !LoadGame.Enabled;
            LoadGame.Visible = !LoadGame.Visible;

            MenuBtn.Enabled = !LoadGame.Enabled;
            MenuBtn.Visible = !LoadGame.Enabled;

            dataGridView1.Enabled = !dataGridView1.Enabled;
            dataGridView1.Visible = !dataGridView1.Visible;

            tabControl.Enabled = !tabControl.Enabled;
            tabControl.Visible = !tabControl.Visible;

        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            if (LoadList.SelectedItem != null)
            {
                if (LoadList.SelectedItem.ToString() != "")
                {
                    dbname = LoadList.SelectedItem.ToString();
                }
            }
            else
            {
                return;
                //tell user why load cancels.

            }

            //Load specific Database
            OpenConnection();

            ToggleUI();
            fillDataGridViews();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            if (saves != null)
            {

                for (int i = 0; i < saves.Length; i++)
                {
                    if ("saves\\" + dbname + ".db" == saves[i])
                    {
                        Exists.Visible = true;
                        return;
                    }
                }
            }

            ToggleUI();

            Generate.DataTables();
            AddtoLoadList();
            fillDataGridViews();
        }


        private void OpenConnection()
        {
            //specifies database name via dbname
            Form1.dbConnection = new SQLiteConnection("Data Source=" + @"saves\" + Form1.dbname + ".db;Version=3;");

            //Opens the connection
            Form1.dbConnection.Open();

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Form1.dbConnection.Close();
            ToggleUI();
        }

        private void NewNameInput_TextChanged(object sender, EventArgs e)
        {
            if (NewNameInput.Text != "")
            {
                Exists.Visible = false;
                dbname = NewNameInput.Text;
            }
            else
            {
                NewNameInput.Text = "Indtast Navn";
            }
        }

        private void fillDataGridViews()
        {
            SQLiteDataAdapter a = new SQLiteDataAdapter("SELECT * FROM Rytter WHERE HoldID = 10", dbConnection);
            DataTable ryttere = new DataTable();
            a.Fill(ryttere);

            SQLiteDataAdapter b = new SQLiteDataAdapter("SELECT * FROM Hold", dbConnection);
            DataTable division = new DataTable();
            b.Fill(division);

            SQLiteDataAdapter c = new SQLiteDataAdapter("SELECT * FROM Træner", dbConnection);
            DataTable træner = new DataTable();
            c.Fill(træner);


            dataGridView1.DataSource = ryttere;

            dataGridView2.DataSource = division;

            dataGridTræner.DataSource = træner;
        }

        private void DeleteSave_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < saves.Length; i++)
            {
                if ("saves\\" + deleteTextBox.Text + ".db" == saves[i])
                {
                    System.IO.File.Delete(saves[i]);
                    LoadList.Items.Remove(deleteTextBox.Text);
                }
            }
        }


        private void buttonSøgTræner_Click(object sender, EventArgs e)
        {
            string input1 = textBoxKøbTræner2.Text;
            string input = textBoxKøbTræner1.Text;
            cmd.Connection = dbConnection;

            if (input == "")
            {
                input = "0";
            }

            string cmdString;

            if (comboBoxKøbTræner5.Visible == true)
            {
                input = comboBoxKøbTræner5.SelectedItem.ToString()+" '%" + input + "%'";
            }
            else
            {
                input = comboBoxKøbTræner2.SelectedItem.ToString()+" "+input + " order by " + comboBoxKøbTræner1.SelectedItem.ToString() + " desc"; 
            }

            

            if (checkBoxKøbTræner1.Checked)
            {
                if (comboBoxKøbTræner6.Visible == true)
                {
                    input1 = comboBoxKøbTræner6.SelectedItem.ToString()+" '%" + input1 + "%'";
                }
                else
                {
                    input1 = comboBoxKøbTræner4.SelectedItem.ToString()+" "+input1 + " order by " + comboBoxKøbTræner3.SelectedItem.ToString() + " desc";
                }

                cmdString = String.Format(" AND {0} {1}", comboBoxKøbTræner3.SelectedItem.ToString(),input1);
            }
            else
            {
                cmdString = "";
            }
                
            cmd.CommandText =String.Format("Select * from Træner where {0} {1}{2}", comboBoxKøbTræner1.SelectedItem.ToString(),input,cmdString);

            SQLiteDataAdapter c = new SQLiteDataAdapter(cmd.CommandText, dbConnection);
            DataTable træner = new DataTable();
            c.Fill(træner);

            dataGridTræner.DataSource = træner;

        }

        private void comboBoxKøbTræner1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKøbTræner1.SelectedItem.ToString() == "Navn" || comboBoxKøbTræner1.SelectedItem.ToString() == "Fokus")
            {
                comboBoxKøbTræner5.Visible = true;
                comboBoxKøbTræner2.Visible = false;

            }
            else
            {
                comboBoxKøbTræner5.Visible = false;
                comboBoxKøbTræner2.Visible = true; 
            }
        }

        private void comboBoxKøbTræner3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKøbTræner3.SelectedItem.ToString() == "Navn" || comboBoxKøbTræner3.SelectedItem.ToString() == "Fokus")
            {
                comboBoxKøbTræner6.Visible = true;
                comboBoxKøbTræner4.Visible = false;

            }
            else
            {
                comboBoxKøbTræner6.Visible = false;
                comboBoxKøbTræner4.Visible = true;
            }
        }
    }
}
