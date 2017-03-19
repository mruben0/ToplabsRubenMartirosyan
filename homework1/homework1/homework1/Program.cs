using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
      
        //1
       static int factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * factorial(x - 1);

            }


        }

      
        //2
        static int gumar(int x, int y)
        {
            if (x == y)
            {
                return (x + y) * 10;
            }
            else
            {
                return x + y;
            }

        }


       
        //3
        static string siebenundzwanzig(int x, int y)
        {
            if (x == 27 || y == 27 || x + y == 27)
            {
                return "TRUE " + "x = " + x + ", " + "y=" + y+ " sum is " +x+y;
            }
            else
            {
                return "FALSE " + "x = " + x + ", " + "y=" + y + " sum is " + x + y;
            }
        }

        

        //4

        static int sizeMatter(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > z)
            {
                return y;
            }
            else
            {
                return z;
            }

        }
     
        //5
        static int manrChunem(int x, int y)
        {
            return x % y;
        }
    

           
        //6
           public static int nishq(int x)
            {
 
          
            if (x < 10)
            {
                return x;
            }
            else {
                string t = Convert.ToString(x);
               
                int u = 0;
               
               
              for (int ind = 0; ind < t.Length; ind++)
                {
                    Console.WriteLine(t[ind]);
                    
                    u += t[ind] - 48;
                    Console.WriteLine(u);
                }
                return u;
                
            } 
            
              
                  

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hi, i am artificial intelligence created by Ruben Martirosyan and its legen.. wait for it...");
            Console.WriteLine("Just write number of task... or your name... oh, its joke, write number:");
            Console.WriteLine("1. factorial");
            Console.WriteLine("2. Gumar");
            Console.WriteLine("3. siebenundzwanzig");
            Console.WriteLine("4. Size IS matter");
            Console.WriteLine("5. ManDr chunem");
            Console.WriteLine("6. Nisherq");
            Console.WriteLine("... Dary, legendery (c)");
            int hamar = Convert.ToInt32(Console.ReadLine());


            switch (hamar)
            {

                case 1:

                    Console.WriteLine("What about factorial?");                
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(factorial(y));
                    Console.Read();
                    break;

                case 2:
                    Console.WriteLine("To lazy to use calc? Just tell me 2 numbers:");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("sum is "+ gumar(k, l));
                        break;

                case 3:
                    Console.WriteLine("Give me 2 numbers, and i'll tell you if there is siebenundzwanzig");
                        int g = Convert.ToInt32(Console.ReadLine());
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(siebenundzwanzig(g, h));
                        break;

                case 4:

                    Console.WriteLine("Write 3 numbers, and i'll give you the big one");
                    int c = Convert.ToInt32(Console.ReadLine());
                     int d = Convert.ToInt32(Console.ReadLine());
                     int e = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("The BIG one issss... whait for it...     "+sizeMatter(c, d, e));
                       break;

                case 5:
                    Console.WriteLine("Write 2 numbers, and i'll give you manDr of your arevtur");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(manrChunem(a, b));
                    break;

                case 6:
                    Console.Write("Write Your number ");
                   int  f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Answer is "+nishq(f));
                    break;
                default:
                    Console.Write("Write Goddamn Number of task");
                    break;
            }

            
            Console.Read();
           
        }
    }
}
