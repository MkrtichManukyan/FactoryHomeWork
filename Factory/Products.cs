using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Factory
{
    internal class Products
    {
        static int day = (int)System.DateTime.Now.Day;

        static string[][] listThings = new string[3][];


    public static void Product()
        {
            for (int i = 0; i <= 2; i++)
            {
                listThings[i] = new string[day];

                for(int j = 0; j < day; j++)
                {
                    if(i == 0)
                    {
                        listThings[i][j] = $"id { j } name { "verarku" } size { "xl" }";
                    }
                    else if (i == 1)
                    {
                        listThings[i][j] = $"id { j } name {"tabat"} size {"34"}";
                    }else if (i == 2)
                    {
                        listThings[i][j] = $"id { j } name {"vernashapik"} size {"x"}";
                    }
                }

            }

            foreach (string[] array in listThings)
            {
                foreach (string element in array)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();
            }


        }
    }
}