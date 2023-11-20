using System;
//Public class to can use in "other window"

public class ReflectionActivity : Activity
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)

    //Classes from the base Class (father)
    //protected string _startingMessage;
    //protected string _activityDuration;
    //protected string _descripciónActivity;
    //protected string _finalActivityMessage;
    private List<string> _listOfPhrases = new List<string>();
    private Random _random = new Random();

    //----------- Constructors section (templates)--------------

    //The default ReflectionActivity when we create
    public ReflectionActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        _listOfPhrases = new List<string>();
        _random = new Random();
    }

    //------------- Constructors section - end ------------------

    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------

    //Return all the elements inside the list
    public List<string> GetAllReflectionPhases()
    {
        return _listOfPhrases;
    }
    //Set the value of the List (if necesary)
    public void SetAllReflectionPhasesList(List<string> phase)
    {
        _listOfPhrases = phase;
    }

    //----------------- Getter & Setter section -----------------
    //-------------------- Methods ------------------------------

    //Method to add one phase to the list
    public void AddPhaseToList(string phase)
    {
        _listOfPhrases.Add(phase);
    }
    //Method to select all the element in the list and print one random
    public string GetRandomChoosenPhrase()
    {
        //Random index inside the list
        int indexOfList = _random.Next(_listOfPhrases.Count);
        return _listOfPhrases[indexOfList];
    }


    //Method to do a cooldown from the max-time to 0 
    public int GetCooldownReflectionActivity(int seconds, List<string> listToUsePhrases, List<string> listaToUseQuestions)
    {
        _listOfPhrases = listToUsePhrases;
        int original = seconds;
        int copy = original;
        DateTime newTime = DateTime.Now.AddSeconds(copy);
        // inicializar variables
        int remaining = seconds;
        string message = "You may begin in: ";
        // mientras queden segundos en el cooldown
        Console.WriteLine("Let's start...");
        ShowSpinnerWithText(" Press enter to initiate the activity");
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        //Print the phrase random
        Random rand = new Random();
        int index = rand.Next(0, listToUsePhrases.Count);
        Console.WriteLine($"---- {listToUsePhrases[index]} ----");

        //Ask to start the reflextion activity (print the questions then)
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
        Console.Write("");
        string enterKey = Console.ReadLine();

        //If the user press 'Enter'
        if (enterKey == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            
            while (DateTime.Now <= newTime){

                //Countdown 3 to 0 with text in the left
            for (int i = 3; i > 0; i--)
            {
                
                Console.SetCursorPosition(x, y);
                // \r delete the line and overwrite it
                Console.Write($"\r{message}" + i);
                Thread.Sleep(1000);
            }

            Console.Clear();
        
            //Print every question waiting for an 'Enter'
            for (int i = 0; i < listaToUseQuestions.Count; i++)
            {
                ShowSpinnerWithText(listaToUseQuestions[i], "right");
                Console.WriteLine();
                
                //If the time is more than the time for the activity break the loop
                if (DateTime.Now >= newTime){
                    break;
                }
            }
            }
            

        }

        return original;
    }

}
