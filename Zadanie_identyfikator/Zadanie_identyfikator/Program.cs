using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.VisualBasic;

namespace Zadanie_identyfikator
{
    class Program
    {
        static String[][] readFile()
        {
            List<String[]> list = new List<String[]>();
            using (StreamReader reader = new StreamReader("identyfikator.txt"))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] values = line.Split(';');
                    list.Add(values);
                }
            }
            return list.ToArray();
        }

        static void Main(string[] args)
        {
            String[][] dane = readFile();
            int max = 0;
            var ids = new Dictionary<string, int>();

            foreach (String[] tab in dane)
            {
                string seria = tab[0].Remove(0,3);
                int suma = 0;

                for(int i = 0; i< seria.Length; i++)
                {
                    int num = Int32.Parse(seria[i].ToString());
                    suma += num;
                    if(suma >= max) {
                        max = suma;
                    }
                }
                ids.Add(tab[0], suma);
            }
            foreach(KeyValuePair<string, int> data in ids.OrderBy(key => key.Value))
            {
                Console.WriteLine(data.Key + " " + data.Value);
            }
        }
    }
}
