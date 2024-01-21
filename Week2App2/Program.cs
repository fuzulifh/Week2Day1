namespace Week2App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Day Number:");
            

            int daynumber = int.Parse(Console.ReadLine());

            if (daynumber == 1) 
            { 
            Console.WriteLine("You Have to go work");
            }
            else if (daynumber == 2) 
            {
                Console.WriteLine("You have to go dinner with Friends");
            }
            else if (daynumber == 3) 
            {
                Console.WriteLine("You have to go London");
            }
            else if (daynumber == 4) 
            {
                Console.WriteLine("You have to go Shopping");
            }
            else if (daynumber == 5) 
            {
                Console.WriteLine("You have to stay at Home");
            }
            else if (daynumber == 6) 
            {
                Console.WriteLine("You have to do your Course");
            }
            else if (daynumber == 7) 
            {
                Console.WriteLine("You have to go Hiking with Friends");
            }
        }
    }
}