using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();


        string option ="";

        while (option != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = randomPrompt;
                    Console.WriteLine($"{randomPrompt}");
                    Console.WriteLine();
                    entry._entryText = Console.ReadLine();
                    myJournal.AddEntry(entry);
                    break;
                    
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadToFile(loadFile);
                    break;
                case "4":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

            }
        }

    }
}