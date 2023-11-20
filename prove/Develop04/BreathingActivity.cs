using System;
//Public class to can use in "other window"

public class BreathingActivity : Activity
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)

    //Classes from the base Class (father)
    //protected string _startingMessage;
    //protected string _activityDuration;
    //protected string _descripciónActivity;
    //protected string _finalActivityMessage;

    private DateTime _cooldownTime;

    //----------- Constructors section (templates)--------------

    //The default BreathingActivity when we create
    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        //Default values
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(0);
    }
    //The BreathingActivity with 1 parameter
    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage, int cooldownTimeActivity) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        //Default values
        //Add 3 zero to the right
        string cooldownTimeString = cooldownTimeActivity.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(int.Parse(cooldownTimeString));
    }

    //------------- Constructors section - end ------------------

    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------

    public DateTime GetCooldown()
    {
        //See the value of _cooldownTime
        return _cooldownTime;
    }

    public void SetTitle(DateTime settedCooldown)
    {
        //Put the value of _cooldownTime
        string cooldownTimeString = settedCooldown.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(int.Parse(cooldownTimeString));

    }

    //----------------- Getter & Setter section -----------------
    //-------------------- Methods ------------------------------

    //Method to do a cooldown from the max-time to 0 changing between Breathe in and out
    //The numbers 3 and 6 are choseen from searching about it
    public int GetCooldownBreatheActivity(int seconds)
    {
        Console.WriteLine("Let's start...");
        ShowSpinnerWithText(" Press enter to initiate the activity");

        const int breatheInDuration = 6;
        const int breatheOutDuration = 3;

        int remainingSeconds = seconds;
        bool isBreathingIn = true;
        while (remainingSeconds > 0)
        {
            Console.Clear();

            int countdown = isBreathingIn ? breatheInDuration : breatheOutDuration;
            string message = isBreathingIn ? "Breathe in..." : "Now breathe out...";

            while (countdown > 0 && remainingSeconds > 0)
            {
                Console.Clear();
                Console.WriteLine($"{message} {countdown}");

                Thread.Sleep(1000);

                countdown--;
                remainingSeconds--;
            }

            isBreathingIn = !isBreathingIn;
        }

        return seconds;
    }

}