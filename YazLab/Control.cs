using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab
{
    public static class Control
    {
        public static string filePath { get; set; }
        public static string fileName { get; set; }
        public static List<string> neighbor = new List<string>();
        public static int inputMatrisSize = 0;
        public static int[,] rMatris = new int[inputMatrisSize, inputMatrisSize];
        public static int[,] qMatris = new int[inputMatrisSize, inputMatrisSize];


        public static void CreateRMatris()
        {
            int i = 0;
            foreach (string value in neighbor)
            {
                if (value.Length > 1)
                {
                    string[] keys = value.Split(',');
                    foreach(string key in keys)
                    {
                        for (int y = 0; y < inputMatrisSize; y++)
                        {
                            if (y.ToString() == key)
                            {
                                rMatris[i, y] = 0;
                            }
                            else
                            {
                                if(rMatris[i,y] != 0)
                                {
                                    rMatris[i, y] = -1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int y = 0; y < inputMatrisSize; y++)
                    {
                        if (y.ToString() == value)
                        {
                            rMatris[i, y] = 0;
                        }
                        else
                        {
                            if (rMatris[i, y] != 0)
                            {
                                rMatris[i, y] = -1;
                            }
                        }
                    }
                }
                i++;
            }
        }
    }
}
