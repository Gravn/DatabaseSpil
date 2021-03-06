﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingManager
{
    class Division
    {
        

        public Division()
        {
            
        }

        public static void AfholdLoeb(string[] ryttere)
        {

            
            
            //Get player rytter data:
            int[,] stats = new int[6,12];
            int[,] id = new int[6,5];

            for (int i = 0; i < ryttere.Length; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (Form1.GetDataString("Rytter", "Navn", ryttere[i], "udholdenhed", j) != "")
                    {
                        id[5,i] = j;
                        stats[5, i] = Int32.Parse(Form1.GetDataString("Rytter", "Navn", ryttere[i], "udholdenhed", j));
                        stats[5, i+5] = Int32.Parse(Form1.GetDataString("Rytter", "Navn", ryttere[i], "styrke", j));
                        stats[5, 10] += Int32.Parse(Form1.GetDataString("Rytter", "Navn", ryttere[i], "støtte", j));
                        stats[5, 11] += Int32.Parse(Form1.GetDataString("Rytter", "Navn", ryttere[i], "overblik", j));
                        
                    }
                }
            }

            //Get ai rytter data:

            for(int i = 1;i<5;i++)
            {
                int x = 0;
                for(int j=0;j<100;j++)
                {
                    if (Form1.GetDataString("Rytter", "HoldID",i.ToString(), "Udholdenhed", j) != "" && x <5)
                    {
                        id[i,x] = j;
                        stats[i, x] = Int32.Parse(Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Udholdenhed", j));
                        stats[i, x+5] = Int32.Parse(Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Styrke", j));
                        stats[i, 10] += Int32.Parse(Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Støtte", j));
                        stats[i, 11] += Int32.Parse(Form1.GetDataString("Rytter", "HoldID", i.ToString(), "Overblik", j));
                        x++;
                    }
                }
            }

            //Udregn rytter resultater:
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    stats[i, j] += (int)(stats[i, 11]*0.1f);
                }

                for (int j = 5; j < 10; j++)
                {
                    stats[i, j] += (int)(stats[i, 10]*0.1f);
                }
            }
            int[] top5P = new int[5];
            int[] top5ID = new int[5];



            string type = Form1.GetDataString("Løb","ID","1","Type",Form1.løbnr);
            if (type == "Flad")
            {
                //FladtLøb ranking:

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (stats[j, k] > top5P[i] && top5ID[0] != id[j, k] && top5ID[1] != id[j, k] && top5ID[2] != id[j, k] && top5ID[3] != id[j, k] && top5ID[4] != id[j, k])
                            {
                                top5P[i] = stats[j, k];
                                top5ID[i] = id[j, k];
                            }
                        }
                    }
                }
            }
            else
            {
                //Bjegløb ranking:
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        for (int k = 5; k < 10; k++)
                        {
                            if (top5ID[0] != id[j, k - 5] && top5ID[0] != id[j, k - 5] && top5ID[1] != id[j, k - 5] && top5ID[2] != id[j, k - 5] && top5ID[3] != id[j, k - 5])
                                if (stats[j, k] > top5P[i])
                                {
                                    top5P[i] = stats[j, k];
                                    top5ID[i] = id[j, k - 5];
                                }
                                else if (stats[j, k] == top5P[i] && i < 4)
                                {
                                    top5P[i + 1] = stats[j, k];
                                    top5ID[i + 1] = id[j, k - 5];
                                }
                        }
                    }
                }
            }

            string[] holdID = new string[5];
            int[] s_points = new int[5];
            int[] score = new int[5];

            for(int i=0;i<5;i++)
            {
                for(int j=0;j<100;j++)
                {
                    if (Form1.GetDataString("Rytter", "ID", top5ID[i].ToString(), "HoldID", j) != "")
                    {
                        holdID[i] = Form1.GetDataString("Rytter", "ID", top5ID[i].ToString(), "HoldID", j);
                    }
                }
                if (Form1.GetDataString("Hold", "ID", holdID[i].ToString(), "Sæson_Point", Int32.Parse(holdID[i])) != "")
                {
                    s_points[i] = Int32.Parse(Form1.GetDataString("Hold", "ID", holdID[i].ToString(), "Sæson_Point",Int32.Parse(holdID[i])));
                    score[i] = Int32.Parse(Form1.GetDataString("Hold", "ID", holdID[i].ToString(), "Score", Int32.Parse(holdID[i])));
                }
                
                //s_points[i]++;
            }
            for (int i = 0; i < 5; i++)
            {
                s_points[Int32.Parse(holdID[i])]++;
                score[Int32.Parse(holdID[i])]++;
            }

            for (int i = 0; i < 5; i++)
            {
                Form1.UpdateDataAbsolute("Hold", "Sæson_Point", s_points[i].ToString(), "ID", (i + 1).ToString());
                Form1.UpdateDataAbsolute("Hold", "Score", (score[i]).ToString(), "ID", (i + 1).ToString());
            }

            Form1.løbnr++;
            if (Form1.løbnr == 10)
            {
                for (int i = 1; i < 6;i++)
                {
                    Form1.UpdateDataAbsolute("Hold", "Sæson_Point","0", "ID",i.ToString());
                }
                Form1.løbnr = 0;
            }
            
        }

    }
}
