using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CyclingManager
{
    class Generate
    {
        public static SQLiteCommand cmd = new SQLiteCommand();
        
        

        public static void DataTables()
        {
            //Create new database
            SQLiteConnection.CreateFile(@"saves\" + Form1.dbname + ".db");

            //specifies database name via dbname
            Form1.dbConnection = new SQLiteConnection("Data Source=" + @"saves\" + Form1.dbname + ".db;Version=3;");

            //Opens the connection
            Form1.dbConnection.Open();
            cmd.Connection = Form1.dbConnection;

            //CREATE

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

            //INSERT

            string[] rytterNavne = System.IO.File.ReadAllLines("RytterNavn.txt");

            string[] holdNavne = System.IO.File.ReadAllLines("Holdnavn.txt");

            string[] sponsorNavne = System.IO.File.ReadAllLines("SponsorNavne.txt");

            string[] løbsnavne = System.IO.File.ReadAllLines("Løbsnavne.txt");

            string[] trænernavne = System.IO.File.ReadAllLines("Trænernavne.txt");

            //Indsætter rytternavne i RytterNavne tabellen
            for (int i = 0; i < rytterNavne.Length; i++)
            {
                cmd.CommandText = String.Format("Insert into Rytternavn (Navn) values ('{0}')", rytterNavne[i]);
                cmd.ExecuteNonQuery();
            }

            //Indsætter holdnavne i Holdnavne tabellen
            for (int i = 0; i < holdNavne.Length; i++)
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
                holdID = i/10+1;

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


            //Indsætter værdierne i Løbs tabellen
            for (int i = 0; i < løbsnavne.Length; i++)
            {
                int etaper = r.Next(1, 5);
                int kmLængde = 150;
                string løbstype = "";

                if (i == 0 | i == 2 | i == 4 | i == 5 | i == 8)
                {
                    løbstype = "Flad";
                }
                else if (i == 1 | i == 3 | i == 6 | i == 7 | i == 9)
                {
                    løbstype = "Bjergrig";
                }

                cmd.CommandText = String.Format("Insert into Løb(Type, Point, Km, Etape) values ('{0}', 'NULL', '{1}', '{2}')", løbstype, kmLængde, etaper);
                cmd.ExecuteNonQuery();
            }
            //Indsætter værdier i Træner tabellen
            for (int i = 0; i < trænernavne.Length; i++)
            {
                int erfaring = r.Next(1, 100);
                int løn = erfaring + 150;
                string fokus = "";

                if (i < 13)
                {
                    fokus = "Sprinter";
                }
                else
                {
                    fokus = "Bjergrytter";
                }

                cmd.CommandText = String.Format("Insert into Træner(HoldID, Erfaring, Fokus, Løn) values ('NULL', '{0}', '{1}', '{2}')", erfaring, fokus, løn);
                cmd.ExecuteNonQuery();

            }

            //Opret spillerhold:
            cmd.CommandText = String.Format("Insert into Hold (Point,Division, Budget, Score) values ('{0}','{1}','{2}','{3}')", 0, 1, 2000, 0);
            cmd.ExecuteNonQuery();

        }
        
        public static void Rider()
        { 
            
        }

        public static void Team()
        { 
            
        }

        public static void Sponsor()
        { 
            
        }

        public static void Division()
        { 
            
        }

        public static void Trainer()
        { 
            
        }

        public static void Stage()
        { 
            
        }
    }
}
