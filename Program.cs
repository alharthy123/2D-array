using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {

            //int zaihlen = 2;
            //int  spalten = 3;
            //int[,] myar2 = new int[zaihlen,spalten];
            //myar2[0,0] = 1; 
            //myar2[0,1] = 2; 
            //myar2[0,2] = 3;    
            //myar2[1,0] = 4; 
            //myar2[1,1] = 5;
            //myar2[1,2] = 6;
            //for(int i = 0; i < zaihlen; i++)
            //{
            //    for(int j = 0; i < spalten; j++)
            //    {

            //       Console.Write(myar2[i, j]);
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            Random ra= new Random();
            int[,]array=new int[4, 4];    
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    array[i,j] = ra.Next(1,100);
                }
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }

            //diogonal

            Console.WriteLine("in der diogmal steht");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(i==j)
                        Console.Write(array[i, j] + "\t");
                }
            }

            //Console.WriteLine("\n");
            //for(int d=0;d <4;d++)
            //{
            //    Console.Write([d,d]+"\t");
            //}




        }
    }
}
