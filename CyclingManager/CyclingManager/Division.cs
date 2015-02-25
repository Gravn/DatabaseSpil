using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CyclingManager
{
    class Division
    {
        
        


        public Division()
        {
            
        }

        public static void AfholdLoeb()
        { 
            //TODO: Indel hold i divisioner, sammenlign rytteres position udfra løbtype, giv points.

            string[,] stats = new string[25,10];

            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = String.Format("Select * From Rytter Where HoldID = 5",Form1.dbConnection);

            command = new SQLiteCommand(command.CommandText, Form1.dbConnection);
            command.ExecuteNonQuery();

            int[,] parsedStats = new int[25, 10];

            for(int i=1;i<6;i++)
            {
                for (int j = 0; i < 5; i++)
                {
                    stats[j, 0] = Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Udholdenhed", j);
                    stats[j, 1] = Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Styrke", j);
                    stats[j, 2] = Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Overblik", j);
                    stats[j, 3] = Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Støtte", j);
                   // parsedStats[i,j] = Int32.Parse(stats[i,j]);
                }
            }


        }

    }
}
