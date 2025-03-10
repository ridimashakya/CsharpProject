string animalID = "";
string animalSpecies = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

int maxPets = 8;
string? readResult;
string menuSelection = "";

string[,] ourAnimals = new string[maxPets, 6];

do
{
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:\r\n1. List all of our current pet information\r\n2. Add a new animal friend to the ourAnimals array\r\n3. Ensure animal ages and physical descriptions are complete\r\n4. Ensure animal nicknames and personality descriptions are complete\r\n5. Edit an animal's age\r\n6. Edit an animal's personality description\r\n7. Display all cats with a specified characteristic\r\n8. Display all dogs with a specified characteristic\r\n\r\nEnter your selection number (or type Exit to exit the program)");
    menuSelection = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":

            for(int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 4:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "7";
                        animalPhysicalDescription = "big white male weighing about 8 pounds. litter box trained";
                        animalPersonalityDescription = "aggressive";
                        animalNickname = "bella";
                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                }

                ourAnimals[i, 0] = animalID;
                ourAnimals[i, 1] = animalSpecies;
                ourAnimals[i, 2] = animalAge;
                ourAnimals[i, 3] = animalNickname;
                ourAnimals[i, 4] = animalPhysicalDescription;
                ourAnimals[i, 5] = animalPersonalityDescription;

            }

            Console.WriteLine("\n");

            for (int i = 0; i < maxPets; i++)
            {
                if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
                {
                    Console.WriteLine("ID #:" + ourAnimals[i, 0]);
                    Console.WriteLine("Species:" + ourAnimals[i, 1]);
                    Console.WriteLine("Age:" + ourAnimals[i, 2]);
                    Console.WriteLine("Nickname:" + ourAnimals[i, 3]);
                    Console.WriteLine("Physical description:" + ourAnimals[i, 4]);
                    Console.WriteLine("Personality:" + ourAnimals[i, 5]);
                }
                Console.WriteLine("\n");
            }

            break;

        case "2":
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;

    }
} while (menuSelection != "exit");



