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
        private Graphics dc;
        private GameWorld gW;
        public static string dbname = "test";

        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public SQLiteConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = CreateGraphics();
            gW = new GameWorld(dc, DisplayRectangle);

            MenuBtn.Visible = false;
            MenuBtn.Enabled = false;

            LoadList.Items.Add("hello.db");

            string[] saves = System.IO.Directory.GetFiles(@"saves\*", ".db");

            foreach (string s in saves)
            {
                //LoadList.Items.Add(s);
            }

            //LoadList.Items.Add("hej");
        }

        private void ticker_Tick_1(object sender, EventArgs e)
        {
            gW.GameLoop();
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
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            //Load specific Database
            ToggleUI();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ToggleUI();

            //Create new database
            SQLiteConnection.CreateFile(@"saves\"+dbname+".db");

            //SQLiteConnection.CreateFile("Data Source=" + dbname + ".db;version=3;");

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

            ////Random som bruges til variablerne/attributterne i Rytter tabellen.
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

                //SQLite command for at sætte værdierne ind i rytter tabellen.
                cmd.CommandText = String.Format("Insert into Rytter (HoldID, Alder, Løn, Udholdenhed, Styrke, Type, Støtte, Overblik, Talent) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", holdID, alder, løn, udholdenhed, styrke, type, støtte, overblik, talent);
                cmd.ExecuteNonQuery();



            }
        }

        private void OpenConnection()
        {

            dbConnection = new SQLiteConnection("Data Source="+@"saves\"+dbname+".db;Version=3;");

            dbConnection = new SQLiteConnection("Data Source=" + dbname + ".db;Version=3;");

            ///Åbner databasen
            dbConnection.Open();

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

            ToggleUI();
        }

        private void NewNameInput_TextChanged(object sender, EventArgs e)
        {
            dbname = NewNameInput.Text;
        }
    }
}
