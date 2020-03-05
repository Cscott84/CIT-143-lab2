using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           

                string a = "         /\\_/\\ ";

                string b = "    /\\  / o o \\";

                string c = "   //\\\\ \\~(*)~/";

                string d = "   /  \\/   ^  \\";

                string e = "      \\  || ||";

                string f = "        \\-()-()";
                
                string extra = "       |  || ||";
                 
                string extra2 = "       \\  || ||";

            Console.WriteLine("Kitty Kitty: ");
            Console.WriteLine($" {a} \n {b} \n {c} \n {d} \n  {e} \n {f} \n");
            
             Console.WriteLine("Please enter the height: ");
             int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the population of kitties you want: ");
            int population = Convert.ToInt32(Console.ReadLine());
           
           

            if(height == 1 && population == 1)
                {


                Console.WriteLine($"{a} \n {b} \n {c} \n {d} \n  {e} \n {f}");


                }

                Console.WriteLine("KITTY KITTY!!");

            if(height> 1 || population > 1)
            {
                for(int i = 0; i < population; i++)
                {
                 Console.Write($"{a}");  
                }
                Console.WriteLine();

                for(int j = 0; j < population; j++)
                    {
                    Console.Write($"{b}");
                    }

                Console.WriteLine();

                for(int h = 0; h < population;h++)
                    {
                    Console.Write(c);
                    }

                Console.WriteLine();

                for(int k = 0; k <population; k++)
                    {
                    Console.Write(d);
                    }

                Console.WriteLine();

                for(int l = 0; l < population;l++)
                    {
                    Console.Write($" {e}");
                    }
                   
                Console.WriteLine();

                for(int n = 0; n < height;n++)
                    {
                        for(int p = 0; p < population;p++)
                        {
                            Console.Write(extra);
                           
                        }
                       Console.WriteLine();

                     }

                for(int r = 0; r < population;r++)
                    {
                        Console.Write(extra2);
                    }
                
                Console.WriteLine();

                for(int m = 0; m < population; m++)
                    {
                    Console.Write(f);
                    }
                
        
                    
             }    
            
            







           

            



        }
        
    }
}
