//

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            //char mySlash = '/';     //Can use myChar instead of "/" in WriteLine

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b); 
            Console.WriteLine((a-1) / b);

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) 
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            else
                Console.WriteLine("Ooops!  Input needs to be 17 and 4.");



            static double AreaOfCircle (double r)
            {
                double area = Math.PI * Math.Pow(r, 2);
                return area;
            }
            Console.WriteLine(" ");     //Insert blank line
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");

        }



    }
