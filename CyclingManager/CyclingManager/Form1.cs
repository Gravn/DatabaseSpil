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
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public SQLiteConnection dbConnection;

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

            //Checks for .db files and adds the names onto the dropdown load list.
            saves = System.IO.Directory.GetFiles(@"saves\", "*.db");
            foreach (string s in saves)
            {
                string[] splitS = s.Split('\\','.');
                
                LoadList.Items.Add(splitS[1]);
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
           

        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            //Load specific Database
            OpenConnection();
            
            ToggleUI();
            fillDataGridViews();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < saves.Length; i++)
                {
                    if ("saves\\"+dbname+".db" == saves[i])
                    {
                        Exists.Visible = true;
                        return;
                    }
                }

            ToggleUI();

                

            //Create new database
            SQLiteConnection.CreateFile(@"saves\"+dbname+".db");

            OpenConnection();

            ////Laver en command til at bruge insert, delete, update og create. 
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;

            cmd.CommandText = "Create table Hold(ID integer primary key, LøbID integer, Point integer, Division integer, Budget integer, Score integer, Foreign Key (LøbID) references Løb(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Holdnavn(ID integer primary key, Navn varchar(40))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Løb(ID integer primary key, Type text, Point integer, Km real, Etape text)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Rytter(ID integer primary key, HoldID integer, Alder integer, Løn integer, Udholdenhed integer, Styrke integer, Type integer, Støtte integer, Overblik integer, Talent integer, Foreign Key (HoldID) references Hold(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Rytternavn(ID integer primary key, Navn varchar(40))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Sponsor(ID integer primary key, HoldID integer, Præmie integer, Foreign Key (HoldID) references Hold(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "create table SponsorNavne(ID integer primary key, Navn varchar(40))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Transfer(ID integer primary key, HoldID integer, RytterID integer, Bud integer, Auktionspris integer, Tid real, Foreign Key (HoldID) references Hold(ID), Foreign Key (RytterID) references Rytter(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Træner(ID integer primary key, HoldID integer, Erfaring integer, Fokus integer, Løn integer, Foreign Key (HoldID) references Hold(ID))";
            cmd.ExecuteNonQuery();


            //Bruges til Rytter og Rytternavne
            string directoryRytter = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] rytterNavne = System.IO.File.ReadAllLines(directoryRytter + @"\RytterNavn.txt");

            //Bruges til Holdnavne
            string directoryHold = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] holdNavne = System.IO.File.ReadAllLines(directoryHold + @"\Holdnavn.txt");

            //Bruges til Sponsor og Sponsornavne
            string secondDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] sponsorNavne = System.IO.File.ReadAllLines(secondDirectory + @"\SponsorNavne.txt");

            //Indsætter rytternavne i RytterNavne tabellen
            for (int i = 0; i < rytterNavne.Length; i++)
            {
                cmd.CommandText = String.Format("Insert into Rytternavn (Navn) values ('{0}')", rytterNavne[i]);
                cmd.ExecuteNonQuery();
            }

            //Indsætter holdnavne i Holdnavne tabellen
            for(int i = 0; i < holdNavne.Length; i++)
            {
                cmd.CommandText = String.Format("Insert into Holdnavn (Navn) values ('{0}')", holdNavne[i]);
                cmd.ExecuteNonQuery();
            }

            //Indsætter Sponsornavne i sponsorNavne tabellen
            for (int i = 0; i < sponsorNavne.Length; i++)
            {
                cmd.CommandText = String.Format("Insert into SponsorNavne (Navn) values ('{0}')", sponsorNavne[i]);
                cmd.ExecuteNonQuery();
            }

            ////Random som bruges til variablerne/attributterne i Rytter og Sponsor tabellen.
            Random r = new Random();

            //Indsætter værdier i Rytter tabellen.
            for (int i = 0; i < rytterNavne.Length; i++)
            {
                //Variabler for alle attributterne i Rytter tabellen. 
                int alder = r.Next(17, 34);
                int udholdenhed = r.Next(0, 100);
                int styrke = r.Next(0, 100);
                int type = 1;
                int overblik = 0;
                int støtte = 0;
                int holdID = 0;
                int talent = r.Next(0, 100);
                int løn = alder + udholdenhed + styrke + 2 * talent;

                if (udholdenhed > styrke)
                {
                    type = 0;
                    støtte = r.Next(0, 100);
                }
                else
                {
                    overblik = r.Next(0, 100);
                    type = 1;
                }

                //Fordeler rytterene på 10 hold, med ti ryttere på hver hold.

                if (i < 10)
                {
                    holdID = 1;
                }
                else if (i < 20)
                {
                    holdID = 2;
                }
                else if (i < 30)
                {
                    holdID = 3;
                }
                else if (i < 40)
                {
                    holdID = 4;
                }
                else if (i < 50)
                {
                    holdID = 5;
                }
                else if (i < 60)
                {
                    holdID = 6;
                }
                else if (i < 70)
                {
                    holdID = 7;
                }
                else if (i < 80)
                {
                    holdID = 8;
                }
                else if (i < 90)
                {
                    holdID = 9;
                }
                else
                {
                    holdID = 10;
                }
                //eller:
                //holdID = i/10+1;

                //SQLite command for at sætte værdierne ind i rytter tabellen.
                cmd.CommandText = String.Format("Insert into Rytter (HoldID, Alder, Løn, Udholdenhed, Styrke, Type, Støtte, Overblik, Talent) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", holdID, alder, løn, udholdenhed, styrke, type, støtte, overblik, talent);
                cmd.ExecuteNonQuery();
            }

            //Indsætter værdierne i Sponsor tabellen
            for (int i = 0; i < sponsorNavne.Length; i++)
            {
                //Variable til at genere præmie attributten i sponsor tabellen
                int præmie = r.Next(2500, 10000);
                //SQLite command for at sætte værdierne ind i sponsor tabellen
                cmd.CommandText = string.Format("insert into sponsor (Præmie) values ('{0}')", præmie);
                cmd.ExecuteNonQuery();
            }

            //Opret spillerhold:
            cmd.CommandText = String.Format("Insert into Hold (Point,Division, Budget, Score) values ('{0}','{1}','{2}','{3}')",0,1,2000,0);
            cmd.ExecuteNonQuery();

            fillDataGridViews();
        }

        private void OpenConnection()
        {
            //specifies database name via dbname
            dbConnection = new SQLiteConnection("Data Source="+@"saves\"+dbname+".db;Version=3;");  
            
            //Opens the connection
            dbConnection.Open();

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
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

        private void LoadList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadList.SelectedText != "")
            {
                dbname = LoadList.SelectedText;
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

            dataGridView1.DataSource = ryttere;

            dataGridView2.DataSource = division;
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
    }
}
