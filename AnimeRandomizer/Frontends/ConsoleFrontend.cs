using System;

namespace AnimeRandomizer.Frontends
{
    static class ConsoleFrontend
    {
        public static void Run()
        {
            Console.Write("Loading Anime... ");
            BackEnd.LoadAnimeXML("AnimeDatabase.xml");
            //BackEnd.LoadAnimeTXT("AnimeList.txt");
            Console.WriteLine("Done. " + BackEnd.AnimeListLength + " Anime loaded");

            bool exit = false;
            while (exit != true)
            {
                Console.Write("\nEnter command: ");

// ReSharper disable PossibleNullReferenceException
                string[] inputArray = Console.ReadLine().Split(new[] {' '}); // Ignoring the ReSharper warning - that error shouldn't occur in this situation
// ReSharper restore PossibleNullReferenceException
                string command = inputArray[0];

                if (command != "")
                {
                    Line();
                    switch (command)
                    {
                        case "add":
                            Add();
                            break;
                        case "exit":
                        case "quit":
                            exit = true;
                            break;
                        case "help":
                            Help();
                            break;
                        case "pick":
                            Pick(1);
                            break;
                        case "pick20":
                            Pick(20);
                            break;
                        case "save":
                            Save();
                            break;
                        default:
                            Console.WriteLine("Invalid command. Type help to see a list of available commands");
                            break;
                    }
                }
            }
        }

        private static void Add()
        {
            Console.Write("Enter the name of the Anime: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a description of Anime (don't press Enter until you have finished!):\n ");
            string description = Console.ReadLine();
            Console.Write("Enter the name of whoever suggested it: ");
            string suggestedBy = Console.ReadLine();

            BackEnd.AddAnime(name, description, suggestedBy, "");

            Console.WriteLine("Anime '" + name + "' added to the database");
        }

        private static void Help()
        {
            Console.WriteLine(
                "Available commands:\n" +
                " add       - start an interface to add a new anime to the database\n" +
                " exit/quit - close this program\n" +
                " help      - display this list of options\n" +
                " pick      - randomly choose an anime from the database and display it's details\n" +
                " save      - save all of the loaded anime to the database"
                );
        }

        private static void Pick(int p_numToPick)
        {
            for (int i = 0; i < p_numToPick; i++)
            {
                Anime anime = BackEnd.SelectAnime();
                Console.WriteLine("NAME: " + anime.Name);
                Console.WriteLine("DESCRIPTION:\n " + anime.Description);
                Console.WriteLine("SUGGESTED BY: " + anime.SuggestedBy);
            }
        }

        private static void Save()
        {
            Console.Write("Saving Anime... ");
            BackEnd.SaveAnime("AnimeDatabase.xml");
            Console.WriteLine("Done.");
        }

        private static void Line()
        {
            Console.WriteLine("".PadRight(80,'-'));
        }
    }
}