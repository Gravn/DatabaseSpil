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
            SQLiteConnection.CreateFile("Data Source=.db;version=3;");

            ToggleUI();
        }

        private void OpenConnection()
        {
            string dbname = "test";
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source="+dbname+".db;Version=3;");

            ///Åbner databasen
            dbConnection.Open();

            ////Laver en command til at bruge insert, delete, update og create. 
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

            ToggleUI();
        }
    }
}
