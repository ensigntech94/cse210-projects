using System;

//Public class to can use in "other window"
public class Reference
{
    //Private class inside the propieties to not affect the working of the program
    private string _book;
    private string _chapter;
    private string _verse;

    private string _verse2;

    //------------------ Constructors section (templates)--------------

    //The default Reference when we create
    public Reference(){
        //Default values
        _book = "Unknown";
        _chapter = "Undefined";
        _verse = "Undefined";
        _verse2 = "n";
    }

    //When the user only put 1 parameter
    //Create a Reference with the chapter 1:1
    public Reference(string bookToInput)
    {
        
        //ex Fraction(Juan) is the same like "Juan 1-1"
        _book = bookToInput;
        _chapter = "1"; //Authomatic assigment
        _verse = "1"; //Authomatic assigment
        _verse2 = "n";
    }

    //When the user only put 2 parameters
    //Create a Reference with the verse with 1 for default
    public Reference(string bookToInput,string chapterToInput)
    {
        
        //ex Fraction(Juan, 1) is the same like "Juan 1-1"
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = "1"; //Authomatic assigment
        _verse2 = "n";
    }
    
    //When the user put 3 parameters
    //Create a Reference completely
    public Reference(string bookToInput, string chapterToInput, string verseToInput){
        
        //ex Fraction(Juan, 5, 2) is the same like "Juan 5-2"
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = verseToInput;
        _verse2 = "n";

    }
    //When the user put 4 parameters
    //Create a Reference completely
    public Reference(string bookToInput, string chapterToInput, string verseToInput, string verseToEnd){
        
        //ex Fraction(Juan, 5, 2) is the same like "Juan 5-2"
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = verseToInput;
        _verse2 = verseToEnd;

    }
    //--------------------- Constructors section - end -------------------

    //--------------------- (Methods - Behaviors) ------------------------
    //--------------------- Getter & Setter section ----------------------
    public string GetBook(){
        //See the value of _book
        return _book;
    }
    public void SetBook(string bookSetted){
        //Put the value of _book
        _book = bookSetted; 
    }
    public string GetChapter(){
        //See the value of _chapter
        return _chapter;
    }
    public void SetChapter(string chapterSetted){
        //Put the value of _chapter
        _chapter = chapterSetted; 
    }    public string GetVerse(){
        //See the value of _verse
        return _verse;
    }
    public void SetVerse(string verseSetted){
        //Put the value of _verse
        _verse = verseSetted; 
    }
public string GetVerseToEnd(){
        //See the value of _verse2
        return _verse2;
    }
    public void SetVerseToEnd(string verseToEndSetted){
        //Put the value of _verse2
        _verse = verseToEndSetted; 
    }    //--------------------- Getter & Setter section - end ----------------

    //--------------------- Methods (functions) --------------------------
    public string GetCompleteReference()
    {
        if (_verse2 == "n")
        {
        //Print the string (ex. return "Juan 1:1")
        string completeReference = $"{_book} {_chapter}:{_verse}";
        return completeReference;
        }
        else{
        //Print the string (ex. return "Juan 1:1-5")
        string completeReference = $"{_book} {_chapter}:{_verse}-{_verse2}";
        return completeReference;

        }
        
    }
    //--------------------- Methods (functions) --------------------------
    //--------------------- (Methods - Behaviors) - End ------------------
    }