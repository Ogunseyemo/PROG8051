// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Virtual Pet Simulator");

        // Choosing your Pet

        Console.WriteLine("Please, choose a type of Pet ");
        Console.WriteLine("1. Cat ");
        Console.WriteLine("2. Dog ");
        Console.WriteLine("3. Rabbit");

        Console.Write("User input:");
        //Read the value of Pet Selected
        string petTypeSelect = Console.ReadLine();
        string petType = ""; }

      /*  //Using pet value to assign Pet name
        if (petTypeSelect == "1")
        {
            petType = "Cat";

        }
        else if (petTypeSelect == "2")
        {
            petType = "Dog";

        }
        else if (petTypeSelect == "3")
        {
            petType = "Rabbit";

        }
        else
        {
            Console.Write("Invalid Option Selected ! ");
        }

        Console.Write("You've Chosen " + petType);
        //Creating your Pet
        Console.WriteLine("  What would you like to name your Pet? : ");
        Console.Write("User input:");

        string petName = Console.ReadLine();

        // Calling a Virtual pet Simulator Class, by declaring an instance of the Class
        VirtualPetSimulator pet = new VirtualPetSimulator(petType, petName);
        pet.DisplayWelcomeMessage();

        while (true)
        {
            //Pet Care Actions menu

            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Feed " + petName);
            Console.WriteLine("2. Play with " + petName);
            Console.WriteLine("3. Let " + petName + " rest");
            Console.WriteLine("4. Check " + petName + "'s" + " status");
            //.WriteLine("5. Simulate time passing");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    pet.Feed();
                    break;
                case "2":
                    pet.Play();
                    break;
                case "3":
                    pet.Rest();
                    break;
                case "4":
                    pet.CheckPetStatus();
                    break;
                case "5":
                    Console.WriteLine($"Thank you for playing with  {petName}. Goodbye !");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            // Simulate time passing after each action
            //pet.SimulateTimePassing();

            // Pause to allow the user to read the updates
            Thread.Sleep(1000);
        }
    }
}

class VirtualPetSimulator
{
    private string petType;
    private string petName;
    private int hunger;
    private int happiness;
    private int health;
    public VirtualPetSimulator(string type, string name)
    {
        //Declaing default value for Virtual Simulator
        petType = type;
        petName = name;
        hunger = 5;
        happiness = 5;
        health = 5;
    }


    // Displaying Welcome message
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome {petName} ! Let''s take care of him.\n");
    }

    // Displaying Status
    public void DisplayStatus()
    {
        Console.WriteLine($"{petName}'s Status:");
        Console.WriteLine($"Hunger: {hunger}\nHappiness: {happiness}\nHealth: {health}\n");
    }


    // Pet care method for Feed
    public void Feed()
    {
        Console.Write($"You fed {petName} ");
        Console.Write("  His hunger decreases, and his health improves slightly.");
        hunger = Math.Max(0, hunger - 2);
        health = Math.Min(10, health + 1);

    }

    // Pet care method for Play
    public void Play()
    {
        Console.WriteLine($"You played with {petName}...");
        Console.Write("His happiness increases, but he is a bit hungry.");
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Min(10, hunger + 1);
    }

    // Pet care method for Rest
    public void Rest()
    {
        Console.WriteLine($"{petName} is resting ");
        Console.Write(" His health improves, but his happiness decreases slightly");

        health = Math.Min(10, health + 2);
        happiness = Math.Max(0, happiness - 1);
    }


    //// Checking Pet Status
    public void CheckPetStatus()
    {
        Console.WriteLine($"Checking {petName}'s status...");
        DisplayStatus();

        // Check for critical conditions
        if (hunger <= 2)
            Console.WriteLine($"{petName} is very hungry. Please feed {petName}!");
        if (happiness <= 2)
            Console.WriteLine($"{petName} is very unhappy. Play with {petName} to cheer it up!");
        if (health <= 2)
            Console.WriteLine($"{petName}'s health is critical. Consider letting {petName} rest!");
    }


    //Simulating Time passing
    public void SimulateTimePassing()
    {
        Console.WriteLine($"Simulating time passing for {petName}...");
        hunger = Math.Min(10, hunger + 1);
        happiness = Math.Max(0, happiness - 1);
        health = Math.Max(0, health - 1);
        DisplayStatus();
    }
}*/

