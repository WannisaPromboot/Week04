using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Your FistName:");
            string FName = Console.ReadLine();

            Console.Write("Your LastName:");
            string LName = Console.ReadLine();

            Console.Write("Your ID:");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your GPA:");
            float GPA = float.Parse(Console.ReadLine());

            Console.WriteLine("First Name: " + FName);
            Console.WriteLine("Last Name: " + LName);
            Console.WriteLine("ID: {0,0:G} ", ID);
            Console.WriteLine("GPA: {0:0.00} ", GPA);
             

        }
    }
}
