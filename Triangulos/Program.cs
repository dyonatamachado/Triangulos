using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            double ladoa = 0;
            double ladob = 0;
            double ladoc = 0;

            if((a != b && b != c) && a != c)
            {
                if(a > b && a > c)
                {
                    if(b > c)
                    {
                        ladoa = a;
                        ladob = b;
                        ladoc = c;
                    } else
                    {
                        ladoa = a;
                        ladob = c;
                        ladoc = b;
                    }
                } else if (a > b && a < c)
                {
                    ladoa = c;
                    ladob = a;
                    ladoc = b;
                } else if (a < b && a < c)
                {
                    if(b < c)
                    {
                        ladoa = c;
                        ladob = b;
                        ladoc = a;
                    }
                    else
                    {
                        ladoa = b;
                        ladob = c;
                        ladoc = a;
                    }
                } else if(a < b && a > c)
                {
                    ladoa = b;
                    ladob = a;
                    ladoc = c;
                }

            } else
            {
                if(a == b)
                {
                   if(a > c)
                    {
                        ladoa = a;
                        ladob = b;
                        ladoc = c;
                    } else
                    {
                        ladoa = c;
                        ladob = a;
                        ladoc = b;
                    }
                } else if (a == c)
                {
                    if (a > b)
                    {
                        ladoa = a;
                        ladob = c;
                        ladoc = b;
                    } else
                    {
                        ladoa = b;
                        ladob = a;
                        ladoc = c;
                    }
                } else if (b == c) 
                { 
                    if(a > b)
                    {
                        ladoa = a;
                        ladob = b;
                        ladoc = c;
                    }
                    else
                    {
                        ladoa = b;
                        ladob = c;
                        ladoc = a;
                    }
                } else if (a == b && a == c)
                {
                    ladoa = a;
                    ladob = b;
                    ladoc = c;
                }
            }

            if (ladoa >= (ladob + ladoc))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if ((ladoa*ladoa) == (ladob*ladob) + (ladoc*ladoc))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if ((ladoa * ladoa) > (ladob * ladob) + (ladoc * ladoc))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if ((ladoa * ladoa) < (ladob * ladob) + (ladoc * ladoc))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ((ladoa == ladob) && (ladoa == ladoc))
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((((ladoa == ladob) && (ladoa != ladoc)) || ((ladoc == ladob) && (ladoa != ladoc))) || ((ladoa == ladoc) && (ladoa != ladob)))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
}
