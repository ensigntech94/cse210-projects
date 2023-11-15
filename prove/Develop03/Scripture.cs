using System;

//Public class to can use in "other window"

public class Scripture
{
     //Private class inside the propieties to not affect the working of the program
    private string _phase;


    //------------------ Constructors section (templates)--------------

    //The default Reference when we create
    public Scripture(){
        //Default values
        _phase = "Unknown";
    }

    //When the user only put 1 parameter
    //Create a Reference with the chapter 1:1
    public Scripture(string phaseToInput)
    {
        
        //ex Scripture("This is the scripture") is the same like "This is the scripture"
        _phase = phaseToInput;
    }
    //--------------------- Constructors section - end -------------------

    //--------------------- (Methods - Behaviors) ------------------------
    //--------------------- Getter & Setter section ----------------------
    public string GetPhase(){
        //See the value of _book
        return _phase;
    }
    public void SetPhase(string phaseToSet){
        //Put the value of _book
        _phase = phaseToSet; 
    }
    //--------------------- Getter & Setter section - end ----------------

    //--------------------- Methods (functions) --------------------------
    public string GetCompleteScripture()
    {
        //Assign the value
        string phaseToReturn = _phase;
        //Assign the value
        return phaseToReturn;

    }
        
    //--------------------- Methods (functions) --------------------------
    //--------------------- (Methods - Behaviors) - End ------------------

}