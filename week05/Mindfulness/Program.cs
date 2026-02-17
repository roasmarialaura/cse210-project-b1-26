using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");
       
        

        string option ="";

        while (option != "4")
        {
            Console.WriteLine("Menu opcion ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from de menu ");
            option = Console.ReadLine();

            if (option == "1")
            {
                new BreathingActivity().Run();
            }
            else if (option == "2")
            {
                new ReflectingActivity().Run();
            }
            else if (option == "3")
            {
                new ListingActivity().Run();
            }
        }

    
    }
}