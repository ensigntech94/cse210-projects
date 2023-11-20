using System;
//Public class to can use in "other window"

public class ListingActivity : Activity
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)

    //Classes from the base Class (father)
    //protected string _startingMessage;
    //protected string _activityDuration;
    //protected string _descripciónActivity;
    //protected string _finalActivityMessage;
    private List<string> _goodThingsList = new List<string>();
    private Random _random = new Random();
    //----------- Constructors section (templates)--------------

    //The default ReflectionActivity when we create
    public ListingActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        _goodThingsList = new List<string>();
        _random = new Random();
    }
    //------------- Constructors section - end ------------------

    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------

    //Return all the elements inside the list
    public List<string> GetAllListingPrompts()
    {
        return _goodThingsList;
    }
    //Set the value of the List (if necesary)
    public void SetAllReflectionPhasesList(List<string> goodThingsPrompts)
    {
        _goodThingsList = goodThingsPrompts;
    }

    //----------------- Getter & Setter section -----------------
    //-------------------- Methods ------------------------------

    //Method to add one phase to the list
    public void AddPhaseToGoodThingsList(string goodThingsPrompts)
    {
        _goodThingsList.Add(goodThingsPrompts);
    }

    //Method to select all the element in the list and print one random
    public string GetRandomChoosenGoodThingsPrompts()
    {
        //Random index inside the list
        int indexOfList = _random.Next(_goodThingsList.Count);
        return _goodThingsList[indexOfList];
    }

    //Method to do a cooldown from the max-time to 0 
    public int GetCooldownListingActivity(int seconds, List<string> listToUsePhrases)
    {
        _goodThingsList = listToUsePhrases;
        int original = seconds;
        DateTime newTime = DateTime.Now.AddSeconds(original);

        Console.WriteLine("Let's start...");
        ShowSpinnerWithText(" Press enter to initiate the activity");

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();

        // Print a random phrase from the list
        Random rand = new Random();
        Console.WriteLine($"---- {listToUsePhrases[rand.Next(listToUsePhrases.Count)]} ----");
        Console.WriteLine();

        // Countdown 3 to 0 with text in the left
        Console.Write("You may begin in: ");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine();

        // Prompt the user to enter responses until time runs out
        List<string> responses = new List<string>();
        while (DateTime.Now <= newTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                break;
            }
            responses.Add(response);
        }

        // Final output
        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items!");

        return original;
    }

}