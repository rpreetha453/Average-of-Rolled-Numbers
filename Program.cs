using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolledNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // string dice;
            int N = Convert.ToInt32(Console.ReadLine());
            int disum = 0;
            for (int i =1; i <=N; i++)
            {
                string s = Console.ReadLine();
                int digit = Threedigit(s);
                disum += digit;
                double avg = average(disum, i);
                output(digit, avg);
            }
        }
            public static int  Threedigit(string s)

            {
                int count = 2;
             int sum = 0;
                string[] ar = s.Split();

                for (int i1 = 0; i1 < ar.Length; i1++)
                {
                   
                    int l = Convert.ToInt32(ar[i1]);
                    double x = l * Math.Pow(10, count);
                    sum += (int)x;
                    count--;
                }
                return sum;
            }

            public static double average(double sum, double count)
            {
                return sum / count;
            }
            public static void output(int s, double avg)
            {
                Console.WriteLine(s + " " + avg);
            }

           

























    


        }
    }

