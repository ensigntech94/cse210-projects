using System;

//Public class to can use in "other window"
public class Word

{
    private bool _hide;

    //--------------------- Constructors section  -----------------------

    //The default Word when we create
    public Word()
    {
        _hide = false;
    }

    //When the user only put 1 parameter
    public Word(bool hide)
    {
        _hide = hide;
    }
    //--------------------- Constructors section - end -------------------

    //--------------------- (Methods - Behaviors) ------------------------
    //--------------------- Getter & Setter section ----------------------
    public bool GetHideState()
    {
        return _hide;
    }
    public void SetHideState(bool hide)
    {
        _hide = hide;
    }
    //--------------------- Getter & Setter section ----------------------

    //Method to get the complete phase
    public void GetCompletePhase(string completePhase, List<string> list, bool condition, string reference)
    {
        Console.WriteLine($"The original phase: {completePhase}");

        //Loop to continue changing letters to "-" until the condition become true (all the words with "-")
        while (list.Any(s => !s.All(c => c == '-')) && condition)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, list.Count);
            string word = list[index];

            Console.WriteLine("Please, press 'Enter' to continue or 'Exit' to quit.");
            string response = Console.ReadLine().ToLower();

            string newWord = "";

            //For letter inside the word
            for (int i = 0; i < word.Length; i++)
            {
                //Change to "-"
                newWord += "-";
            }

            list[index] = newWord;

            string ultimatePhase = string.Empty;

            //For each word inside the phase
            for (int i = 0; i < list.Count; i++)
            {
                ultimatePhase += list[i].ToString() + " ";
            }

            string completeQuote = $"The current phase: {reference} {ultimatePhase}";

            //If the user put "exit" in the input
            if (response != "exit")
            {
                //Clean the console and get the current phase
                Console.Clear();
                Console.WriteLine(completeQuote);
            }
            else
            {
                //"Apply" enter
                Console.WriteLine("");
            }

            //Whe the user put exit, finish the loop
            if (response == "exit")
            {
                condition = false;
            }
        }
    }


}