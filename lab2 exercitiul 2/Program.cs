using System;

namespace lab2_exercitiul_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Ex2();
            //Ex3();



            Console.ReadLine();
        }
        static void Ex2()
        {
            //daca numerele sunt pare, atunci imi calculeaza media aritmetica
            //(2+4+6+8)/4
            Console.WriteLine("Introduceti numarul n");
            
            
            int n = int.Parse(Console.ReadLine());
            int nr;

            if (n > 0)
            {
                int cateSuntPare = 0;
                int suma = 0;

                for (int i = 1; i <= n; i++)//
                {
                    Console.WriteLine(" Citeste numarul ");
                    nr = int.Parse(Console.ReadLine());

                    if (nr % 2 == 0)//daca e par
                    {
                        suma = suma + nr;//il adaug la suma

                        cateSuntPare = cateSuntPare + 1;//si il si numar


                    }
                }

                decimal mediaAritmetica = 0;

                if (cateSuntPare != 0)
                    mediaAritmetica = (decimal) suma / cateSuntPare;

                Console.WriteLine("mediaAritmetica=" + mediaAritmetica);


                 






            }
        }
    }

}



        


    


