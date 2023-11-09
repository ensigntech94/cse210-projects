//Unit 02 Develop: Journal Program

using System;
using System.Collections.Generic;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {

        //------------------------------------- Get the user data - Start -------------------------------------------------------------------------------------
        
        //Get from the user the name and assign to the propiety _name
            Console.Write("Enter your full name: ");
            string userName = Console.ReadLine();   
            Journal myJournal = new Journal();//Use the constructor of class Journal

            //Convert the fist letter of the string _name to capital letter
            myJournal._name = char.ToUpper(userName[0]) + userName.Substring(1);
            
            

        //--------------------------------------- Get the user data - End -------------------------------------------------------------------------------------

            //List of notifications()
            List<string> localStorageList = new List<string>();


        //--------------------------------------- Information about the file.csv --------------------------------------------------------------------------------------------
       
       //Reading Text Files
       //string filename = "myFile.csv";

        //--------------------------------------- Information about the file.csv --------------------------------------------------------------------------------------------
        bool exitProgram = false;
        while(!exitProgram){

    
            //List of notifications()
            List<string> notificationsList = new List<string>()
            {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How can I be better at my job today?",
            "How has my actions blessed the life of someone today?"
            };

            //Display the menu
            Console.WriteLine("Please select one of the following choices?");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Quit");
            Console.Write("What do you like to do? ");
            string chargedFile= "No";
            string answerFileToLoad;
            string optionChoose = Console.ReadLine();
            

            switch (optionChoose)
            {

            //------------------------------------------------------------- Write option - Start -------------------------------------------------------------------------------
                    case "1":

                    //------------------------------Entry class propieties and methods (objects) - Start------------------------------------------------------------------------
                    //Function to random the elements inside the list
                    Random random = new Random();
                    int num = random.Next(0, 6);//Number min 0 and max 6
                    //Entry (entry of journal 1 - propieties)
                    Entry entry1 = new Entry();//Use the constructor of class Entry
                    //Console.WriteLine(notificationsList[num]); //Number random between the elements 0-6
                    entry1._message = notificationsList[num];
                    Console.WriteLine(entry1._message);
                    //Get from the user the answer and assign to the propiety _response
                    Console.Write("Enter your response: ");
                    string userentryResponse = Console.ReadLine();
                    //Convert the fist letter of the string _response to capital letter
                    entry1._response = char.ToUpper(userentryResponse[0]) + userentryResponse.Substring(1);
                    //Add to the empty list the entries (because if you don'n add, you couldn't display the information)
                    myJournal._entries.Add(entry1);
                                        
                    //Display the Entry information (method)
                    //entry1.Display()
                    //-------------------------------Entry class propieties and methods (objects) - End--------------------------------------------------------------------------
                    break;
            //------------------------------------------------------------- Write option - End --------------------------------------------------------------------------



            // ---------------------------------------------------------------- Display the journal - Start----------------------------------------------------------------------
                case "2":
                    if(chargedFile == "Yes"){
                    //WORKING → 
                    foreach (string item in localStorageList)
                    {
                        Console.WriteLine(item);
                    }
                    //Temporaly memory entries
                     myJournal.Display();//Add the entries to the list Journal

                    Console.WriteLine("To save the current list, please save it.");
                    }
                    
                    else if(chargedFile == "No"){
                    Console.WriteLine("------------------------------------------------------");
                    //Temporaly memory entries
                    myJournal.Display();//Add the entries to the list Journal

                    //Display the Journal information (Temporaly memory entries)
                    Console.WriteLine("------------------------------------------------------");

                    Console.WriteLine("To save the current list, please save it.");

                    };

                    break;
            // ---------------------------------------------------------------- Display the journal - End ------------------------------------------------------------------------


            
                case "3":
                
                    chargedFile= "No";
                    //Get the file to load from the outline
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    answerFileToLoad = Console.ReadLine();
                    string filename = answerFileToLoad;
                    
                    //Read all the lines in the file "myFile.csv" in this case
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                            Console.WriteLine(line);
                            localStorageList.Add(line);                            
                    }
                    Console.WriteLine("File loaded.");
                    
                    //Clear the data saved in the list ("temporaly memory")
                    //myJournal._entries.Clear();
                    chargedFile= "Yes";
                    break;


            
            // ---------------------------------------------------------------- Save the journal - Start----------------------------------------------------------------------
                case "4":

                    //Get the file to send the outline
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    string answerFileToSave = Console.ReadLine();
                    
                    //Save the data to the ourline (to the file "myFile.csv" in this case)
                    using (StreamWriter outputFile = new StreamWriter(answerFileToSave))
                    {  
                    //Display outline start
                        //Print the header(only)                  
                        outputFile.WriteLine("------------------------------------------------------");
                        outputFile.WriteLine($"Name: {myJournal._name}");

                        //For each entry in the myJournal List
                        foreach (Entry entry in myJournal._entries)
                        {

                        //Print the prompt and the response
                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: "+entry._message);
                        outputFile.WriteLine($"{entry._response}");
                        
                        }
                        //Print the final line(only)                
                        outputFile.WriteLine("------------------------------------------------------");
                        
                    };

                    break;
            // ---------------------------------------------------------------- Save the journal - End --------------------------------------------------------------------------


            
            // ----------------------------------------------------------------  Exit  -------------------------------------------------------------------------------------------
                case "5":
                    exitProgram = true;
                    break;
            // ----------------------------------------------------------------  Exit  -------------------------------------------------------------------------------------------
                
                
                default:
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }
        
            }
           

        
        
    }
}