using System;

    public class Domain
    {
        //Private class inside the propieties to not affect the working of the program
        private string _reference;
        private string _scripture;

        //------------------ Constructors section (templates)--------------

        //The default Domain when we create
        public Domain()
        {
            //Default values
            _reference = "Unknown";
            _scripture = "Unknown";
        }
        //When the user only put 1 parameter
        public Domain(string referenceToInput)
        {
            //Create a Domain with the name of the Reference
            _reference = referenceToInput;
            _scripture = "";
        }
        //When the user only put 2 parameters
        //Create a Domain with the Scripture 
        public Domain(string referenceToInput, string scriptureToInput)
        {
            //Complete Domain
            _reference = referenceToInput;
            _scripture = scriptureToInput;
        }
        //--------------------- Constructors section - end -------------------

        //--------------------- (Methods - Behaviors) ------------------------
        //--------------------- Getter & Setter section ----------------------
        //--------------------- (Not necessary) ------------------------------
        /*     public string GetReference(){
                //See the value of _book
                return _reference;
            }
            public void SetReference(string bookSetted){
                //Put the value of _book
                _reference = bookSetted; 
            }
            public string GetScripture(){
                //See the value of _book
                return _scripture;
            }
            public void SetScripture(string scriptureSetted){
                //Put the value of _book
                _scripture = scriptureSetted; 
            } 
        */
        //--------------------- Methods (functions) --------------------------

        public string CompletePhase()
        {
            string phrase = _reference + " " + _scripture;

            return phrase;
        }
        

        //--------------------- Methods (functions) --------------------------
        //--------------------- (Methods - Behaviors) - End ------------------
    }
