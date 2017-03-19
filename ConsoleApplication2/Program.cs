using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[,] Decoder = new string[33, 2] { { "37", " " }, { "24", "E" }, { "10", "T" }, { "22", "A" }, { "28", "O" }, { "0E", "R" }, { "26", "I" }, { "0F", "S" }, { "0B", "N" }, { "06", "H" }, { "09", "L" }, { "03", "D" }, { "2A", "U" }, { "12", "W" }, { "2C", "Y" }, { "04", "F" }, { "0A", "M" }, { "02", "C" }, { "05", "G" }, { "01", "B" }, { "0C", "P" }, { "31", "." }, { "08", "K" }, { "32", "," }, { "11", "V" }, { "36", "’" }, { "13", "X" }, { "35", ":" }, { "07", "J" }, { "0D", "Q" }, { "14", "Z" }, { "33", ";" }, { "34", "?" } };
            string Input_Text = "1";
            string Output_Text = "";
            string D = "";

            while (Input_Text.Length % 2 != 0)
            {
                Console.WriteLine("\n Please enter source text with even number of symbols");
                // Input_Text = Console.ReadLine();
                // хрень
                while (true)
                {
                    char ch = Convert.ToChar(Console.Read());
                    sb.Append(ch);
                    if (ch == '\n')
                    {
                        break;
                    }
                }
                // хрень
                //Console.WriteLine(sb);
                //Console.ReadKey();

                Input_Text = Convert.ToString(sb); 

                //Console.WriteLine("Длинна строки - {0}", Input_Text.Length);
                //if (Input_Text.Length % 2 == 0)
                //    Console.WriteLine("lenght - OK");
                //else Console.WriteLine("lenght - HE OK");
            }

            Console.WriteLine(" ---------------Decoding....--------------\n");

            for (int i = 0; i < Input_Text.Length/2; i++)
            {
                Console.WriteLine("Step {0}", i);

                D = Input_Text.Substring(i * 2,2);
                //if (i < Input_Text.Length / 2 - 1)
                //{
                //    D = D.Remove(2);
                //}
                    D = D.ToUpper();
                Console.WriteLine("Txt {0}", D);
                int ZZZ = 0;           
                   for (int x = 0; x < Decoder.GetLength(0)-1; x++)
                   {
                    if (D == Decoder[x, 0])
                        {
                        Output_Text = Output_Text + Decoder[x, 1];
                        ZZZ = 1;
                        }
                   }
                if (ZZZ == 0) {
                    Console.WriteLine("Illegal symbol in text input ! Try again!");
                    break; }


            }

          
            Console.WriteLine("Decoded text: \n\n '{0}'", Output_Text);

            // Console.WriteLine("----------------------------------------");

            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
            //Console.WriteLine(Input_Text.Remove(3));
            

        }
    }
}














