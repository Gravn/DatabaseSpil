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
            Title.Visible = true;

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

            budgetLabel.Visible = !budgetLabel.Visible;         

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

            budgetLabel.Text = "Budget: " + GetBudget() + " kr";
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
            budgetLabel.Text = "Budget: " + GetBudget() + " kr";
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
            budgetLabel.Text = "Budget: " + GetBudget() + " kr";
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
            SQLiteDataAdapter a = new SQLiteDataAdapter("SELECT * FROM Rytter WHERE HoldID = 5", dbConnection);
            DataTable ryttere = new DataTable();
            a.Fill(ryttere);

            SQLiteDataAdapter b = new SQLiteDataAdapter("SELECT * FROM Hold", dbConnection);
            DataTable division = new DataTable();
            b.Fill(division);

            SQLiteDataAdapter c = new SQLiteDataAdapter("SELECT * FROM Træner Where HoldID = 0", dbConnection);
            DataTable træner = new DataTable();
            c.Fill(træner);

            SQLiteDataAdapter d = new SQLiteDataAdapter("SELECT * FROM Rytter Where HoldID = 0", dbConnection);
            DataTable købRytter = new DataTable();
            d.Fill(købRytter);

            SQLiteDataAdapter f = new SQLiteDataAdapter("SELECT * FROM Sponsor", dbConnection);
            DataTable sponsorer = new DataTable();
            f.Fill(sponsorer);

            dataGridView1.DataSource = ryttere;

            dataGridView2.DataSource = division;

            dataGridTræner.DataSource = træner;

            dataGridRytter.DataSource = købRytter;

            dataGridSponsor.DataSource = sponsorer;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSøgTræner_Click(object sender, EventArgs e)
        {

            string input = textBoxKøbTræner1.Text;
            string input1 = textBoxKøbTræner2.Text;
            cmd.Connection = dbConnection;

            if (input == "")
            {
                input = "0";
            }


            int i = 0;
            int i1 = 0;
            bool inputisInt = Int32.TryParse(input, out i);
            bool input1isInt = Int32.TryParse(input1, out i1);

            string secondString;

            if (comboBoxKøbTræner5.Visible)
            {
                input = comboBoxKøbTræner5.SelectedItem.ToString() + " '%" + input + "%'";
            }
            else
            {
                if (inputisInt)
                {
                    input = i.ToString();
                    input = comboBoxKøbTræner2.SelectedItem.ToString() + " " + input;
                }
                else
                {
                    //Input type must be int.

                    return;
                }
            }

            if (checkBoxKøbTræner1.Checked)
            {
                if (comboBoxKøbTræner6.Visible)
                {
                    input1 = comboBoxKøbTræner6.SelectedItem.ToString() + " '%" + input1 + "%'";
                }
                else
                {
                    if (input1isInt)
                    {
                        input1 = i1.ToString();
                        input1 = comboBoxKøbTræner4.SelectedItem.ToString() + " " + input1 + " order by " + comboBoxKøbTræner1.SelectedItem.ToString() + " desc";
                    }
                    else
                    {
                        //Input type must be int.

                        return;
                    }
                }
                secondString = String.Format(" AND {0} {1}", comboBoxKøbTræner3.SelectedItem.ToString(), input1);
            }
            else
            {
                secondString = " order by " + comboBoxKøbTræner1.SelectedItem.ToString() + " desc";
            }

            cmd.CommandText = String.Format("Select * from Træner where {0} {1}{2}", comboBoxKøbTræner1.SelectedItem.ToString(), input, secondString);

            SQLiteDataAdapter c = new SQLiteDataAdapter(cmd.CommandText, dbConnection);
            DataTable træner = new DataTable();
            c.Fill(træner);

            dataGridTræner.DataSource = træner;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSøgRytter_Click(object sender, EventArgs e)
        {
            string input = textInput1KøbRytter.Text;
            string input1 = textInput2KøbRytter.Text;
            cmd.Connection = dbConnection;

            if (input == "")
            {
                input = "0";
            }

            int i = 0;
            int i1 = 0;
            bool inputisInt = Int32.TryParse(input, out i);
            bool input1isInt = Int32.TryParse(input1, out i1);

            string secondString;

            if (comboBoxOperator1KøbRytterString.Visible)
            {
                input = comboBoxOperator1KøbRytterString.SelectedItem.ToString() + " '%" + input + "%'";
            }
            else
            {
                if (inputisInt)
                {
                    input = i.ToString();
                    input = comboBoxOperator1KøbRytterINT.SelectedItem.ToString() + " " + input;
                }
                else
                {
                    //Input type must be int.

                    return;
                }
            }

            if (checkBoxKøbRytter1.Checked)
            {
                if (comboBoxOperator2KøbRytterString.Visible)
                {
                    input1 = comboBoxOperator2KøbRytterString.SelectedItem.ToString() + " '%" + input1 + "%'";
                }
                else
                {
                    if (input1isInt)
                    {
                        input1 = i1.ToString();
                        input1 = comboBoxOperator2KøbRytterINT.SelectedItem.ToString() + " " + input1 + " order by " + comboBoxParam1KøbRytter.SelectedItem.ToString() + " desc";
                    }
                    else
                    {
                        //Input type must be int.

                        return;
                    }
                }
                secondString = String.Format(" AND {0} {1}", comboBoxParam2KøbRytter.SelectedItem.ToString(), input1);
            }
            else
            {
                secondString = " order by " + comboBoxParam1KøbRytter.SelectedItem.ToString() + " desc";
            }

            cmd.CommandText = String.Format("Select * from Rytter where {0} {1} AND HoldID = 0{2}", comboBoxParam1KøbRytter.SelectedItem.ToString(), input, secondString);

            SQLiteDataAdapter d = new SQLiteDataAdapter(cmd.CommandText, dbConnection);
            DataTable købRytter = new DataTable();
            d.Fill(købRytter);

            dataGridRytter.DataSource = købRytter;
        }

        
        private void btnKøbTræner_Click(object sender, EventArgs e)
        {
            cmd.Connection = dbConnection;
            string input = textBoxAngivIDKTræner.Text;

            cmd.CommandText = String.Format("Select * from Træner where ID = {0}", input);
            cmd.ExecuteNonQuery();


            SQLiteCommand command = new SQLiteCommand(cmd.CommandText, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            int løn = 0;
            
            while(reader.Read())
            {
                løn = Int32.Parse((reader["Løn"]).ToString());
            }

            int trænerPris = løn * 4;

            if (GetBudget() >= trænerPris)
            {
                cmd.CommandText = String.Format("Update Træner set HoldID = 5 where ID = {0}", input);
                cmd.ExecuteNonQuery();

                SQLiteDataAdapter c = new SQLiteDataAdapter("Select * from Træner", dbConnection);
                DataTable træner = new DataTable();
                c.Fill(træner);

                dataGridTræner.DataSource = træner;

                SetBudget(-trænerPris);

                fillDataGridViews();
            }
            else
            {
                budgetWarningTræner.Visible = true;
            }

        }

        private void buttonSøgSponsor_Click(object sender, EventArgs e)
        {
            string input = textBoxSøgSponsor.Text;
            cmd.Connection = dbConnection;

            if (input == "")
            {
                input = "0";
            }

            int i = 0;
            bool inputisInt = Int32.TryParse(input, out i);

            if (comboBoxSøgOpeSponsorString.Visible)
            {
                input = comboBoxSøgOpeSponsorString.SelectedItem.ToString() + " '%" + input + "%'";
            }
            else
            {
                if (inputisInt)
                {
                    input = i.ToString();
                    input = comboBoxSøgOpeSponsorINT.SelectedItem.ToString() + " " + input;
                }
                else
                {
                    //Input type must be int.
                    return;
                }
            }

            string secondString = " order by " + comboBoxParamSøgSponsor.SelectedItem.ToString() + " desc";

            cmd.CommandText = String.Format("Select * from Sponsor where {0} {1} {2}", comboBoxParamSøgSponsor.SelectedItem.ToString(), input, secondString);

            SQLiteDataAdapter f = new SQLiteDataAdapter(cmd.CommandText, dbConnection);
            DataTable sponsorer = new DataTable();
            f.Fill(sponsorer);

            dataGridSponsor.DataSource = sponsorer;
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

        private void comboBoxKøbRytter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxParam1KøbRytter.SelectedItem.ToString() == "Navn")
            {
                comboBoxOperator1KøbRytterString.Visible = true;
                comboBoxOperator1KøbRytterINT.Visible = false;
            }
            else
            {
                comboBoxOperator1KøbRytterString.Visible = false;
                comboBoxOperator1KøbRytterINT.Visible = true;
            }
        }

        private void comboBoxKøbRytter4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxParam2KøbRytter.SelectedItem.ToString() == "Navn")
            {
                comboBoxOperator2KøbRytterString.Visible = true;
                comboBoxOperator2KøbRytterINT.Visible = false;
            }
            else
            {
                comboBoxOperator2KøbRytterString.Visible = false;
                comboBoxOperator2KøbRytterINT.Visible = true;
            }
        }

        

        private void comboBoxParamSøgSponsor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxParamSøgSponsor.SelectedItem.ToString() == "Navn")
            {
                comboBoxSøgOpeSponsorString.Visible = true;
                comboBoxSøgOpeSponsorINT.Visible = false;
            }
            else
            {
                comboBoxSøgOpeSponsorString.Visible = false;
                comboBoxSøgOpeSponsorINT.Visible = true;
            }
        }


        private int GetBudget()
        {
            cmd.Connection = dbConnection;
            
            cmd.CommandText = String.Format("Select * from Hold where ID = 5", dbConnection);
            SQLiteCommand command = new SQLiteCommand(cmd.CommandText, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            int i = 0;

            while (reader.Read())
            {
                i = Int32.Parse((reader["Budget"]).ToString());
            }


            return i;
        }

        private void SetBudget(int change)
        {
            
            int newBudget = GetBudget() + change;

            cmd.CommandText = String.Format("Update Hold set Budget = {0} where ID = 5", newBudget);
            cmd.ExecuteNonQuery();

            budgetLabel.Text = "Budget: " + newBudget + " kr";

            fillDataGridViews();
        }


    }
}
