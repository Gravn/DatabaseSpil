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

            LoadList.Items.Add("hej");

            string[] saves = System.IO.Directory.GetFiles(path+@"saves\", ".db");

            foreach (string s in saves)
            {
                LoadList.Items.Add(s);
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
            //Create new database
            SQLiteConnection.CreateFile(@"saves\"+dbname+".db");

            OpenConnection();

            ////Laver en command til at bruge insert, delete, update og create. 
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;

            cmd.CommandText = "Create table Hold(ID integer primary key, LøbID integer, Point integer, Division integer, Budget integer, Score integer, Foreign Key (LøbID) references Løb(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Løb(ID integer primary key, Type text, Point integer, Km real, Etape text)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Rytter(ID integer primary key, HoldID integer, Alder integer, Løn integer, Udholdenhed integer, Styrke integer, Type integer, Støtte integer, Overblik integer, Talent integer, Foreign Key (HoldID) references Hold(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table RytterNavne(ID integer primary key, Navn varchar(40))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Sponsor(ID integer primary key, HoldID integer, Præmie integer, Foreign Key (HoldID) references Hold(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Transfer(ID integer primary key, HoldID integer, RytterID integer, Bud integer, Auktionspris integer, Tid real, Foreign Key (HoldID) references Hold(ID), Foreign Key (RytterID) references Rytter(ID))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Create table Træner(ID integer primary key, HoldID integer, Erfaring integer, Fokus integer, Løn integer, Foreign Key (HoldID) references Hold(ID))";
            cmd.ExecuteNonQuery();


            ToggleUI();
        }

        private void OpenConnection()
        {
            dbConnection = new SQLiteConnection(@"saves\Data Source="+dbname+".db;Version=3;");

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
