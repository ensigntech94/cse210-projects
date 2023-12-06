using System;

class Program
{
    static void Main(string[] args)
    {

        //  -------------------------------------------------------- Functions to clean the code (repeat in 3 stories) --------------------------------------------------------
        void GetDungeonIntroduction()
        {
            Console.WriteLine("Welcome to the dungeon of the underworld");
            Console.WriteLine();

            Console.WriteLine("You have entered a place of mystery and danger, where danger lurks around every corner and treasure awaits the bravest of heroes.");
            Console.WriteLine("This treacherous dungeon is filled with ferocious monsters and ancient relics, and it is said that only the bravest of heroes have returned alive.");
            Console.WriteLine();

            Console.WriteLine("A long time ago, this dungeon was built by an evil sorcerer who enjoyed seeing how far he could reach the heroes' ability in an environment full of challenges like the one he prepared.");
            Console.WriteLine("Over the years, this dungeon has become a place of legend, drawing adventurers from far and wide in search of riches and fame.");
            Console.WriteLine("But beware, many have entered and few have returned, as the dangers of this dungeon are unlike anything you have faced before.");
            Console.WriteLine();

            Console.WriteLine("Do you have what it takes to survive Underworld's Dungeon? Let the adventure begin!");
            Console.WriteLine();

        };

        //  -------------------------------------------------------- Functions to clean the code (repeat in 3 stories) --------------------------------------------------------


        //Variables
        int userExperiencePoints = 0; //user's point (started with 0)
        int userPointsToAssign = 0; //The points the user has to assign to his skills
        int option = 0; //user's choose menu options (started with 0)
        int optionSubMenu = 0; //user's choose menu options (started with 0)
        int currentlyGameArcher = 0; //user's choose menu story options (started with 0)
        int currentlyGameKnight = 0; //user's choose menu story options (started with 0)
        int currentlyGameWizard = 0; //user's choose menu story options (started with 0)
        int storyOptions = 0; //user's choose menu options (started with 0)
        int currentlyBAttleOptions = 0; //user's choose battle options
        int chargedOptions = 0; //user's load menu options (started with 0)

        //Variables to create the Load (option 2 in the first menu)
        string PJToLoad = "";
        bool fileCharged = false;

        //Samples to charge a PJ
        PJArcher archer = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
        PJKnight knight = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
        PJWizard wizard = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
        //Sample of inventory
        Inventory archerInventory = new Inventory();
        Inventory knightInventory = new Inventory();
        Inventory wizardInventory = new Inventory();

        while (option != 3)
        {
            //If the option was 2 before
            if (fileCharged)
            {
                option = 1;
            }

            //Normal flow
            else
            {
                //Reset the switch
                option = 0;

                //Display the menu
                Console.Clear();
                Console.WriteLine("Dungeon of the underworld");
                Console.WriteLine();
                Console.WriteLine("[1] New game");
                Console.WriteLine("[2] Load game");
                Console.WriteLine("[3] Quit");
                Console.WriteLine();
                Console.Write("Select a choice from the menu: ");
                option = int.Parse(Console.ReadLine());
            }


            switch (option)
            {

                //------------------ "[1] New game"  -------------------- 
                case 1:

                    if (fileCharged)
                        optionSubMenu = 0;
                    Console.Clear();

                    while (optionSubMenu != 4)
                    {
                        //If the option was 2 before
                        if (fileCharged)
                        {
                            //Conditionals to manipulate dynamically the menu (loaded game in option 2 - main menu)
                            if (fileCharged && PJToLoad == "archer")
                            {
                                optionSubMenu = 1;
                            }
                            else if (fileCharged && PJToLoad == "knight")
                            {
                                optionSubMenu = 2;
                            }
                            else if (fileCharged && PJToLoad == "wizard")
                            {
                                optionSubMenu = 3;
                            }
                        }

                        //Normal flow
                        else
                        {
                            Console.WriteLine("Dungeon of the underworld");
                            Console.WriteLine();
                            Console.WriteLine("Choose your character");
                            Console.WriteLine();
                            Console.WriteLine("[1] Archer");
                            Console.WriteLine("[2] Knight");
                            Console.WriteLine("[3] Wizard");
                            Console.WriteLine("[4] Return to main menu");
                            Console.WriteLine();
                            Console.Write("Select a choice from the menu: ");
                            optionSubMenu = int.Parse(Console.ReadLine());
                        }


                        switch (optionSubMenu)
                        {
                            //--- "[1] Archer" --- 
                            case 1:

                                Console.Clear();

                                if (fileCharged)
                                {

                                }

                                //Normal flow
                                else
                                {
                                    //Reset the variables
                                    userPointsToAssign = archer.GetPointsToAssign();
                                    userExperiencePoints = archer.GetExperiencePoints();

                                    //Create the Character
                                    //PJArcher archer = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);

                                    //Define the skills (Use this method to control the stats)
                                    archer.SetlifePoints(200);
                                    archer.SetManaPoints(300);
                                    archer.SetExperiencePoints(0);
                                    archer.SetPointsToAssign(5);
                                    userPointsToAssign = archer.GetPointsToAssign();
                                    archer.SetLevel(1);
                                    archer.SetHealPotions(2);
                                    archer.SetManaPotions(2);
                                    archer.SetPhysicalDamage(30);
                                    archer.SetMagicDamage(20);
                                    archer.SetAttackSpeed(20);
                                    archer.SetCelerity(10);
                                    archer.SetSpecialMoveTitle("Raining Arrows");
                                    archer.SetSpecialMoveDamage(60);

                                }

                                //Presentation
                                GetDungeonIntroduction();
                                Console.Write("Press any key to return to continue ");
                                Console.ReadLine();

                                while (currentlyGameArcher == 0)
                                {
                                    storyOptions = 0;

                                    while (storyOptions != 7)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dungeon of the underworld");
                                        Console.WriteLine();
                                        Console.WriteLine($"You have {archer.GetExperiencePoints()} experience points.");
                                        Console.WriteLine($"You have {archer.GetPointsToAssign()} points to assign.");
                                        Console.WriteLine();
                                        Console.WriteLine("[1] Battle");
                                        Console.WriteLine("[2] Display stats");
                                        Console.WriteLine("[3] Display inventory");
                                        Console.WriteLine("[4] Upgrade skills");
                                        Console.WriteLine("[5] Save game");
                                        Console.WriteLine("[6] Load game");
                                        Console.WriteLine("[7] Quit");
                                        Console.WriteLine();
                                        Console.Write("Select a choice from the menu: ");
                                        storyOptions = int.Parse(Console.ReadLine());
                                        switch (storyOptions)
                                        {
                                            //----------------- "[1] Battle"  ---------------- 
                                            case 1:

                                                //Reset the switcher
                                                int battleMenuOptions = 0;

                                                //Enemy's custom
                                                int enemyLevel = 1;
                                                int enemyType = 1; //Get a default orc enemy


                                                while (battleMenuOptions != 4)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Dungeon of the underworld");
                                                    Console.WriteLine();
                                                    Console.WriteLine("[1] Start battle");
                                                    Console.WriteLine("[2] Change enemy's type");
                                                    Console.WriteLine("[3] Change enemy's level");
                                                    Console.WriteLine("[4] Return to main menu");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Note: If you do not choose a level or an enemy type, the battle will be by default with a level 1 orc.");
                                                    Console.WriteLine();
                                                    Console.Write("Select a choice from the menu: ");
                                                    battleMenuOptions = int.Parse(Console.ReadLine());
                                                    switch (battleMenuOptions)
                                                    {
                                                        //--------- Battle Start ------------
                                                        case 1:
                                                            //Create the enemy depends the enemyType

                                                            //Orc
                                                            if (enemyType == 1)
                                                            {
                                                                NPCOrc orc = new(70, 120, enemyLevel, 20, 10, 10, 5, "Skull breaker", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {

                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    orc.SetlifePoints(orc.GetlifePoints() + ((orc.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    orc.SetManaPoints(orc.GetManaPoints() + ((orc.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 28% physical damage points depends the enemy's level
                                                                    orc.SetPhysicalDamage(orc.GetPhysicalDamage() + ((orc.GetPhysicalDamage() * enemyLevel) / 7));
                                                                    //Upgrade 16% magic damage points depends the enemy's level
                                                                    orc.SetMagicDamage(orc.GetMagicDamage() + ((orc.GetMagicDamage() * enemyLevel) / 12));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    orc.SetAttackSpeed(orc.GetAttackSpeed() + ((orc.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    orc.SetCelerity(orc.GetCelerity() + ((orc.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    orc.SetSpecialMoveDamage(orc.GetSpecialMoveDamage() + ((orc.GetSpecialMoveDamage() * enemyLevel) / 20));


                                                                }
                                                                Console.Clear();

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a orc level {orc.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {archer.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The Orc has {orc.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (archer.GetlifePoints() > 0 && orc.GetlifePoints() > 0)
                                                                {
                                                                    Console.Clear();

                                                                    Console.WriteLine($"Orc's has : {orc.GetlifePoints()} life points and {orc.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {archer.GetlifePoints()} life points and {archer.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackPhysicalDamagePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackPhysicalDamagePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackMagicDamagePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackMagicDamagePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackSpecialMovePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackSpecialMovePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }

                                                                }

                                                                //When the character lose the battle
                                                                if (archer.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable orc beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameArcher = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless orc and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    archer.SetHealPotions(archer.GetHealPotions() + potionToReceive);
                                                                    archer.SetManaPotions(archer.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Orc bone", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    archerInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    archer.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }


                                                            //Banshee
                                                            else if (enemyType == 2)
                                                            {
                                                                NPCBanshee banshe = new(50, 120, enemyLevel, 10, 20, 10, 10, "Mournful wail", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {
                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    banshe.SetlifePoints(banshe.GetlifePoints() + ((banshe.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    banshe.SetManaPoints(banshe.GetManaPoints() + ((banshe.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 16% physical damage points depends the enemy's level
                                                                    banshe.SetPhysicalDamage(banshe.GetPhysicalDamage() + ((banshe.GetPhysicalDamage() * enemyLevel) / 12));
                                                                    //Upgrade 28% magic damage points depends the enemy's level
                                                                    banshe.SetMagicDamage(banshe.GetMagicDamage() + ((banshe.GetMagicDamage() * enemyLevel) / 7));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    banshe.SetAttackSpeed(banshe.GetAttackSpeed() + ((banshe.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    banshe.SetCelerity(banshe.GetCelerity() + ((banshe.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    banshe.SetSpecialMoveDamage(banshe.GetSpecialMoveDamage() + ((banshe.GetSpecialMoveDamage() * enemyLevel) / 20));
                                                                }
                                                                Console.Clear();

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a banshee level {banshe.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {archer.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The banshee has {banshe.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (archer.GetlifePoints() > 0 && banshe.GetlifePoints() > 0)
                                                                {
                                                                    //Ataques ya estan hechos, fisico magico y especial
                                                                    //tomar posion vida y mana

                                                                    //Agregar items al inventario
                                                                    //Una vez terminado con el banshee debemos hacer lo mismo en los otros

                                                                    Console.Clear();

                                                                    Console.WriteLine($"Banshee's has : {banshe.GetlifePoints()} life points and {banshe.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {archer.GetlifePoints()} life points and {archer.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackPhysicalDamagePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackPhysicalDamagePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackMagicDamagePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackMagicDamagePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackSpecialMovePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackSpecialMovePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }

                                                                }

                                                                //When the character lose the battle
                                                                if (archer.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable skull warrior beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameArcher = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless banshee and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    archer.SetHealPotions(archer.GetHealPotions() + potionToReceive);
                                                                    archer.SetManaPotions(archer.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Banshee cloth shard", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    archerInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    archer.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }


                                                            //Skull warrior
                                                            else if (enemyType == 3)
                                                            {
                                                                NPCSkull skullWarrior = new(30, 50, enemyLevel, 15, 0, 15, 10, "Gore charge", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {
                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    skullWarrior.SetlifePoints(skullWarrior.GetlifePoints() + ((skullWarrior.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    skullWarrior.SetManaPoints(skullWarrior.GetManaPoints() + ((skullWarrior.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 28% physical damage points depends the enemy's level
                                                                    skullWarrior.SetPhysicalDamage(skullWarrior.GetPhysicalDamage() + ((skullWarrior.GetPhysicalDamage() * enemyLevel) / 7));
                                                                    //Upgrade 16% magic damage points depends the enemy's level
                                                                    skullWarrior.SetMagicDamage(skullWarrior.GetMagicDamage() + ((skullWarrior.GetMagicDamage() * enemyLevel) / 12));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    skullWarrior.SetAttackSpeed(skullWarrior.GetAttackSpeed() + ((skullWarrior.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    skullWarrior.SetCelerity(skullWarrior.GetCelerity() + ((skullWarrior.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    skullWarrior.SetSpecialMoveDamage(skullWarrior.GetSpecialMoveDamage() + ((skullWarrior.GetSpecialMoveDamage() * enemyLevel) / 20));
                                                                }

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a banshee level {skullWarrior.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {archer.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The Banshee has {skullWarrior.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (archer.GetlifePoints() > 0 && skullWarrior.GetlifePoints() > 0)
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine($"Skull warrior's has : {skullWarrior.GetlifePoints()} life points and {skullWarrior.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {archer.GetlifePoints()} life points and {archer.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackPhysicalDamagePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackPhysicalDamagePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackMagicDamagePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackMagicDamagePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.AttackSpecialMovePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.AttackSpecialMovePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (archer.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                archer.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(archer);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(archer);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(archer);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                archer.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }


                                                                }

                                                                //When the character lose the battle
                                                                if (archer.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable skull warrior beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameArcher = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless skull warrior and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    archer.SetHealPotions(archer.GetHealPotions() + potionToReceive);
                                                                    archer.SetManaPotions(archer.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Jaw bone", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    archerInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    archer.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }

                                                            break;
                                                        //--------- Battle Start ------------


                                                        //--------- Custom enemy's type ------------
                                                        case 2:
                                                            string enemyTypeString = ""; //Variable to help the user to show the enemy's type

                                                            Console.Clear();
                                                            Console.WriteLine();
                                                            Console.WriteLine("[1] Orc");
                                                            Console.WriteLine("[2] Banshe");
                                                            Console.WriteLine("[3] Skull warrior");
                                                            Console.WriteLine("[4] Return to main menu");
                                                            Console.WriteLine();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomType = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomType, out int customType))
                                                            {
                                                                if (settingCustomType == "1") { enemyTypeString = "orc"; }
                                                                else if (settingCustomType == "2") { enemyTypeString = "banshe"; }
                                                                else if (settingCustomType == "3") { enemyTypeString = "skull warrior"; }

                                                                Console.WriteLine($"The type was changed to {enemyTypeString} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyType = customType;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's type - End --------


                                                        //--------- Custom enemy's level ------------
                                                        case 3:
                                                            Console.Clear();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomLevel = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomLevel, out int customLevel))
                                                            {
                                                                Console.WriteLine($"The level was changed to {customLevel} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyLevel = customLevel;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's level - End --------


                                                        case 4:
                                                            storyOptions = 0;
                                                            break;


                                                        default:
                                                            Console.Clear();
                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                            break;
                                                    }
                                                }
                                                break;
                                            //------------ "[1] Battle - End"  --------------- 

                                            //----------------- "[2] Stats"  ---------------- 
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine(archer.GetAllStats());
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[2] Stats - End"  -------------- 



                                            //----------------- "[3] Inventory"  ---------------- 
                                            case 3:
                                                Console.Clear();
                                                archerInventory.Display();
                                                Console.WriteLine();
                                                Console.WriteLine($"Heal potions: {archer.GetHealPotions()}");
                                                Console.WriteLine($"Mana potions: {archer.GetManaPotions()}");
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[3] Inventory - End"  -------------- 


                                            //----------------- "[4] Upgrade skills"  ---------------- 
                                            case 4:
                                                Console.Clear();
                                                archer.UpgradeSkills(archer.GetPointsToAssign());
                                                break;
                                            //------------- "[4] Upgrade skills - End"  -------------- 


                                            //------------------ "[5] Save Stats"  ------------------- 
                                            case 5:
                                                Console.Clear();
                                                Console.Write("What is the filename for the game file (ex: GameSavedFile.csv)? ");
                                                string fileName = Console.ReadLine();
                                                using (StreamWriter outputFile = new StreamWriter(fileName))
                                                {
                                                    // You can add userExperiencePoints in the moment
                                                    // You can add userPointsToAssign in the moment
                                                    outputFile.WriteLine(archer.GetExperiencePoints());
                                                    outputFile.WriteLine(archer.GetPointsToAssign());


                                                    //Save the current stats
                                                    outputFile.WriteLine(archer.GetlifePoints());
                                                    outputFile.WriteLine(archer.GetManaPoints());
                                                    outputFile.WriteLine(archer.GetExperiencePoints());
                                                    outputFile.WriteLine(archer.GetPointsToAssign());
                                                    outputFile.WriteLine(archer.GetLevel());
                                                    outputFile.WriteLine(archer.GetHealPotions());
                                                    outputFile.WriteLine(archer.GetManaPotions());
                                                    outputFile.WriteLine(archer.GetPhysicalDamage());
                                                    outputFile.WriteLine(archer.GetMagicDamage());
                                                    outputFile.WriteLine(archer.GetAttackSpeed());
                                                    outputFile.WriteLine(archer.GetCelerity());
                                                    outputFile.WriteLine(archer.GetSpecialMoveTitle());
                                                    outputFile.WriteLine(archer.GetSpecialMoveDamage());

                                                    //For each item inside the list, save a line with different formats(override in the class)
                                                    foreach (var item in archerInventory._items)
                                                    {
                                                        //Save all the items inside the list
                                                        outputFile.WriteLine(item._name + "," + item._quantity);

                                                    }


                                                }
                                                break;
                                            //------------------ "[5] Save Stats"- End --------------- 


                                            //------------------ "[6] Load Stats"- End --------------- 
                                            case 6:
                                                Console.Clear();
                                                //Charge the information
                                                archer.ChargeInformation(archer, userExperiencePoints, userPointsToAssign, archerInventory);
                                                break;
                                            //------------------ "[6] Load Stats"- End --------------- 


                                            //--------------- [7] Quit ---------------------
                                            case 7:
                                                currentlyGameArcher = 1;
                                                break;
                                            //--------------- [7] Quit ---------------------


                                            default:
                                                Console.WriteLine("Wrong.Choose another option");
                                                break;
                                        }

                                        //Finish the program (close all the loops)
                                        optionSubMenu = 4;
                                        option = 3;
                                        break;
                                    }
                                }
                                break;
                            //--- "[1] Archer - End" --- 


                            //--- "[2] Knight" --- 
                            case 2:

                                if (fileCharged)
                                {

                                }

                                //Normal flow
                                else
                                {
                                    Console.Clear();

                                    //Reset the variables
                                    userPointsToAssign = knight.GetPointsToAssign();
                                    userExperiencePoints = knight.GetExperiencePoints();

                                    //Create the Character
                                    //PJKnight knight = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);

                                    //Define the skills (Use this method to control the stats)
                                    knight.SetlifePoints(400);
                                    knight.SetManaPoints(150);
                                    knight.SetExperiencePoints(0);
                                    knight.SetPointsToAssign(5);
                                    userPointsToAssign = 5;
                                    knight.SetLevel(1);
                                    knight.SetHealPotions(2);
                                    knight.SetManaPotions(2);
                                    knight.SetPhysicalDamage(50);
                                    knight.SetMagicDamage(5);
                                    knight.SetAttackSpeed(15);
                                    knight.SetCelerity(20);
                                    knight.SetSpecialMoveTitle("Piercing thrust");
                                    knight.SetSpecialMoveDamage(60);

                                }


                                //Presentation
                                GetDungeonIntroduction();
                                Console.Write("Press any key to return to continue ");
                                Console.ReadLine();

                                while (currentlyGameKnight == 0)
                                {
                                    storyOptions = 0;

                                    while (storyOptions != 7)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dungeon of the underworld");
                                        Console.WriteLine();
                                        Console.WriteLine($"You have {knight.GetExperiencePoints()} experience points.");
                                        Console.WriteLine($"You have {knight.GetPointsToAssign()} points to assign.");
                                        Console.WriteLine();
                                        Console.WriteLine("[1] Battle");
                                        Console.WriteLine("[2] Display stats");
                                        Console.WriteLine("[3] Display inventory");
                                        Console.WriteLine("[4] Upgrade skills");
                                        Console.WriteLine("[5] Save game");
                                        Console.WriteLine("[6] Load game");
                                        Console.WriteLine("[7] Quit");
                                        Console.WriteLine();
                                        Console.Write("Select a choice from the menu: ");
                                        storyOptions = int.Parse(Console.ReadLine());
                                        switch (storyOptions)
                                        {
                                            //----------------- "[1] Battle"  ---------------- 
                                            case 1:

                                                //Reset the switcher
                                                int battleMenuOptions = 0;

                                                //Enemy's custom
                                                int enemyLevel = 1;
                                                int enemyType = 1; //Get a default orc enemy


                                                while (battleMenuOptions != 4)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Dungeon of the underworld");
                                                    Console.WriteLine();
                                                    Console.WriteLine("[1] Start battle");
                                                    Console.WriteLine("[2] Change enemy's type");
                                                    Console.WriteLine("[3] Change enemy's level");
                                                    Console.WriteLine("[4] Return to main menu");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Note: If you do not choose a level or an enemy type, the battle will be by default with a level 1 orc.");
                                                    Console.WriteLine();
                                                    Console.Write("Select a choice from the menu: ");
                                                    battleMenuOptions = int.Parse(Console.ReadLine());
                                                    switch (battleMenuOptions)
                                                    {
                                                        //--------- Battle Start ------------
                                                        case 1:
                                                            //Create the enemy depends the enemyType

                                                            //Orc
                                                            if (enemyType == 1)
                                                            {
                                                                NPCOrc orc = new(70, 120, enemyLevel, 20, 10, 10, 5, "Skull breaker", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {

                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    orc.SetlifePoints(orc.GetlifePoints() + ((orc.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    orc.SetManaPoints(orc.GetManaPoints() + ((orc.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 28% physical damage points depends the enemy's level
                                                                    orc.SetPhysicalDamage(orc.GetPhysicalDamage() + ((orc.GetPhysicalDamage() * enemyLevel) / 7));
                                                                    //Upgrade 16% magic damage points depends the enemy's level
                                                                    orc.SetMagicDamage(orc.GetMagicDamage() + ((orc.GetMagicDamage() * enemyLevel) / 12));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    orc.SetAttackSpeed(orc.GetAttackSpeed() + ((orc.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    orc.SetCelerity(orc.GetCelerity() + ((orc.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    orc.SetSpecialMoveDamage(orc.GetSpecialMoveDamage() + ((orc.GetSpecialMoveDamage() * enemyLevel) / 20));


                                                                }
                                                                Console.Clear();

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a orc level {orc.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {knight.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The Orc has {orc.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (knight.GetlifePoints() > 0 && orc.GetlifePoints() > 0)
                                                                {
                                                                    Console.Clear();

                                                                    Console.WriteLine($"Orc's has : {orc.GetlifePoints()} life points and {orc.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {knight.GetlifePoints()} life points and {knight.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackPhysicalDamagePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackPhysicalDamagePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackMagicDamagePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackMagicDamagePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackSpecialMovePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackSpecialMovePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }

                                                                }

                                                                //When the character lose the battle
                                                                if (knight.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable orc beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameKnight = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless orc and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    knight.SetHealPotions(knight.GetHealPotions() + potionToReceive);
                                                                    knight.SetManaPotions(knight.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Orc bone", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    knightInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    knight.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }


                                                            //Banshee
                                                            else if (enemyType == 2)
                                                            {
                                                                NPCBanshee banshe = new(50, 120, enemyLevel, 10, 20, 10, 10, "Mournful wail", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {
                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    banshe.SetlifePoints(banshe.GetlifePoints() + ((banshe.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    banshe.SetManaPoints(banshe.GetManaPoints() + ((banshe.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 16% physical damage points depends the enemy's level
                                                                    banshe.SetPhysicalDamage(banshe.GetPhysicalDamage() + ((banshe.GetPhysicalDamage() * enemyLevel) / 12));
                                                                    //Upgrade 28% magic damage points depends the enemy's level
                                                                    banshe.SetMagicDamage(banshe.GetMagicDamage() + ((banshe.GetMagicDamage() * enemyLevel) / 7));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    banshe.SetAttackSpeed(banshe.GetAttackSpeed() + ((banshe.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    banshe.SetCelerity(banshe.GetCelerity() + ((banshe.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    banshe.SetSpecialMoveDamage(banshe.GetSpecialMoveDamage() + ((banshe.GetSpecialMoveDamage() * enemyLevel) / 20));
                                                                }
                                                                Console.Clear();

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a banshee level {banshe.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {knight.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The banshee has {banshe.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (knight.GetlifePoints() > 0 && banshe.GetlifePoints() > 0)
                                                                {
                                                                    //Ataques ya estan hechos, fisico magico y especial
                                                                    //tomar posion vida y mana

                                                                    //Agregar items al inventario
                                                                    //Una vez terminado con el banshee debemos hacer lo mismo en los otros

                                                                    Console.Clear();

                                                                    Console.WriteLine($"Banshee's has : {banshe.GetlifePoints()} life points and {banshe.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {knight.GetlifePoints()} life points and {knight.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackPhysicalDamagePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackPhysicalDamagePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackMagicDamagePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackMagicDamagePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackSpecialMovePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackSpecialMovePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }

                                                                }

                                                                //When the character lose the battle
                                                                if (knight.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable skull warrior beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameKnight = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless banshee and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    knight.SetHealPotions(knight.GetHealPotions() + potionToReceive);
                                                                    knight.SetManaPotions(knight.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Banshee cloth shard", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    knightInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    knight.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }


                                                            //Skull warrior
                                                            else if (enemyType == 3)
                                                            {
                                                                NPCSkull skullWarrior = new(30, 50, enemyLevel, 15, 0, 15, 10, "Gore charge", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {
                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    skullWarrior.SetlifePoints(skullWarrior.GetlifePoints() + ((skullWarrior.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    skullWarrior.SetManaPoints(skullWarrior.GetManaPoints() + ((skullWarrior.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 28% physical damage points depends the enemy's level
                                                                    skullWarrior.SetPhysicalDamage(skullWarrior.GetPhysicalDamage() + ((skullWarrior.GetPhysicalDamage() * enemyLevel) / 7));
                                                                    //Upgrade 16% magic damage points depends the enemy's level
                                                                    skullWarrior.SetMagicDamage(skullWarrior.GetMagicDamage() + ((skullWarrior.GetMagicDamage() * enemyLevel) / 12));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    skullWarrior.SetAttackSpeed(skullWarrior.GetAttackSpeed() + ((skullWarrior.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    skullWarrior.SetCelerity(skullWarrior.GetCelerity() + ((skullWarrior.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    skullWarrior.SetSpecialMoveDamage(skullWarrior.GetSpecialMoveDamage() + ((skullWarrior.GetSpecialMoveDamage() * enemyLevel) / 20));
                                                                }

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a banshee level {skullWarrior.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {knight.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The Banshee has {skullWarrior.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (knight.GetlifePoints() > 0 && skullWarrior.GetlifePoints() > 0)
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine($"Skull warrior's has : {skullWarrior.GetlifePoints()} life points and {skullWarrior.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {knight.GetlifePoints()} life points and {knight.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackPhysicalDamagePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackPhysicalDamagePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackMagicDamagePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackMagicDamagePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.AttackSpecialMovePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.AttackSpecialMovePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (knight.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                knight.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(knight);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(knight);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(knight);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                knight.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }


                                                                }

                                                                //When the character lose the battle
                                                                if (knight.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable skull warrior beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameKnight = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless skull warrior and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    knight.SetHealPotions(knight.GetHealPotions() + potionToReceive);
                                                                    knight.SetManaPotions(knight.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Jaw bone", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    knightInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    knight.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }

                                                            break;
                                                        //--------- Battle Start ------------


                                                        //--------- Custom enemy's type ------------
                                                        case 2:
                                                            string enemyTypeString = ""; //Variable to help the user to show the enemy's type

                                                            Console.Clear();
                                                            Console.WriteLine();
                                                            Console.WriteLine("[1] Orc");
                                                            Console.WriteLine("[2] Banshe");
                                                            Console.WriteLine("[3] Skull warrior");
                                                            Console.WriteLine("[4] Return to main menu");
                                                            Console.WriteLine();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomType = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomType, out int customType))
                                                            {
                                                                if (settingCustomType == "1") { enemyTypeString = "orc"; }
                                                                else if (settingCustomType == "2") { enemyTypeString = "banshe"; }
                                                                else if (settingCustomType == "3") { enemyTypeString = "skull warrior"; }

                                                                Console.WriteLine($"The type was changed to {enemyTypeString} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyType = customType;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's type - End --------


                                                        //--------- Custom enemy's level ------------
                                                        case 3:
                                                            Console.Clear();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomLevel = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomLevel, out int customLevel))
                                                            {
                                                                Console.WriteLine($"The level was changed to {customLevel} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyLevel = customLevel;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's level - End --------


                                                        case 4:
                                                            storyOptions = 0;
                                                            break;


                                                        default:
                                                            Console.Clear();
                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                            break;
                                                    }
                                                }
                                                break;
                                            //------------ "[1] Battle - End"  --------------- 

                                            //----------------- "[2] Stats"  ---------------- 
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine(knight.GetAllStats());
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[2] Stats - End"  -------------- 



                                            //----------------- "[3] Inventory"  ---------------- 
                                            case 3:
                                                Console.Clear();
                                                knightInventory.Display();
                                                Console.WriteLine();
                                                Console.WriteLine($"Heal potions: {knight.GetHealPotions()}");
                                                Console.WriteLine($"Mana potions: {knight.GetManaPotions()}");
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[3] Inventory - End"  -------------- 


                                            //----------------- "[4] Upgrade skills"  ---------------- 
                                            case 4:
                                                Console.Clear();
                                                knight.UpgradeSkills(knight.GetPointsToAssign());
                                                break;
                                            //------------- "[4] Upgrade skills - End"  -------------- 


                                            //------------------ "[5] Save Stats"  ------------------- 
                                            case 5:
                                                Console.Clear();
                                                Console.Write("What is the filename for the game file (ex: GameSavedFile.csv)? ");
                                                string fileName = Console.ReadLine();
                                                using (StreamWriter outputFile = new StreamWriter(fileName))
                                                {
                                                    // You can add userExperiencePoints in the moment
                                                    // You can add userPointsToAssign in the moment
                                                    outputFile.WriteLine(knight.GetExperiencePoints());
                                                    outputFile.WriteLine(knight.GetPointsToAssign());


                                                    //Save the current stats
                                                    outputFile.WriteLine(knight.GetlifePoints());
                                                    outputFile.WriteLine(knight.GetManaPoints());
                                                    outputFile.WriteLine(knight.GetExperiencePoints());
                                                    outputFile.WriteLine(knight.GetPointsToAssign());
                                                    outputFile.WriteLine(knight.GetLevel());
                                                    outputFile.WriteLine(knight.GetHealPotions());
                                                    outputFile.WriteLine(knight.GetManaPotions());
                                                    outputFile.WriteLine(knight.GetPhysicalDamage());
                                                    outputFile.WriteLine(knight.GetMagicDamage());
                                                    outputFile.WriteLine(knight.GetAttackSpeed());
                                                    outputFile.WriteLine(knight.GetCelerity());
                                                    outputFile.WriteLine(knight.GetSpecialMoveTitle());
                                                    outputFile.WriteLine(knight.GetSpecialMoveDamage());

                                                    //For each item inside the list, save a line with different formats(override in the class)
                                                    foreach (var item in knightInventory._items)
                                                    {
                                                        //Save all the items inside the list
                                                        outputFile.WriteLine(item._name + "," + item._quantity);

                                                    }


                                                }
                                                break;
                                            //------------------ "[5] Save Stats"- End --------------- 


                                            //------------------ "[6] Load Stats"- End --------------- 
                                            case 6:
                                                Console.Clear();
                                                //Charge the information
                                                knight.ChargeInformation(knight, userExperiencePoints, userPointsToAssign, knightInventory);
                                                break;
                                            //------------------ "[6] Load Stats"- End --------------- 


                                            //--------------- [7] Quit ---------------------
                                            case 7:
                                                currentlyGameKnight = 1;
                                                break;
                                            //--------------- [7] Quit ---------------------


                                            default:
                                                Console.WriteLine("Wrong.Choose another option");
                                                break;
                                        }

                                        //Finish the program (close all the loops)
                                        optionSubMenu = 4;
                                        option = 3;
                                        break;
                                    }
                                }
                                break;
                            //--- "[2] Knight - End" --- 


                            //--- "[3] Wizard" --- 
                            case 3:

                                if (fileCharged)
                                {

                                }

                                //Normal flow
                                else
                                {
                                    Console.Clear();

                                    //Reset the variables
                                    userPointsToAssign = wizard.GetPointsToAssign();
                                    userExperiencePoints = wizard.GetExperiencePoints();

                                    //Create the Character
                                    //PJWizard wizard = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);

                                    //Define the skills (Use this method to control the stats)
                                    wizard.SetlifePoints(200);
                                    wizard.SetManaPoints(400);
                                    wizard.SetExperiencePoints(0);
                                    wizard.SetPointsToAssign(5);
                                    userPointsToAssign = 5;
                                    wizard.SetLevel(1);
                                    wizard.SetHealPotions(2);
                                    wizard.SetManaPotions(2);
                                    wizard.SetPhysicalDamage(10);
                                    wizard.SetMagicDamage(50);
                                    wizard.SetAttackSpeed(15);
                                    wizard.SetCelerity(30);
                                    wizard.SetSpecialMoveTitle("Ruler of the elements");
                                    wizard.SetSpecialMoveDamage(80);
                                }

                                //Presentation
                                GetDungeonIntroduction();
                                Console.Write("Press any key to return to continue ");
                                Console.ReadLine();

                                while (currentlyGameWizard == 0)
                                {
                                    storyOptions = 0;

                                    while (storyOptions != 7)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dungeon of the underworld");
                                        Console.WriteLine();
                                        Console.WriteLine($"You have {wizard.GetExperiencePoints()} experience points.");
                                        Console.WriteLine($"You have {wizard.GetPointsToAssign()} points to assign.");
                                        Console.WriteLine();
                                        Console.WriteLine("[1] Battle");
                                        Console.WriteLine("[2] Display stats");
                                        Console.WriteLine("[3] Display inventory");
                                        Console.WriteLine("[4] Upgrade skills");
                                        Console.WriteLine("[5] Save game");
                                        Console.WriteLine("[6] Load game");
                                        Console.WriteLine("[7] Quit");
                                        Console.WriteLine();
                                        Console.Write("Select a choice from the menu: ");
                                        storyOptions = int.Parse(Console.ReadLine());
                                        switch (storyOptions)
                                        {
                                            //----------------- "[1] Battle"  ---------------- 
                                            case 1:

                                                //Reset the switcher
                                                int battleMenuOptions = 0;

                                                //Enemy's custom
                                                int enemyLevel = 1;
                                                int enemyType = 1; //Get a default orc enemy


                                                while (battleMenuOptions != 4)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Dungeon of the underworld");
                                                    Console.WriteLine();
                                                    Console.WriteLine("[1] Start battle");
                                                    Console.WriteLine("[2] Change enemy's type");
                                                    Console.WriteLine("[3] Change enemy's level");
                                                    Console.WriteLine("[4] Return to main menu");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Note: If you do not choose a level or an enemy type, the battle will be by default with a level 1 orc.");
                                                    Console.WriteLine();
                                                    Console.Write("Select a choice from the menu: ");
                                                    battleMenuOptions = int.Parse(Console.ReadLine());
                                                    switch (battleMenuOptions)
                                                    {
                                                        //--------- Battle Start ------------
                                                        case 1:
                                                            //Create the enemy depends the enemyType

                                                            //Orc
                                                            if (enemyType == 1)
                                                            {
                                                                NPCOrc orc = new(70, 120, enemyLevel, 20, 10, 10, 5, "Skull breaker", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {

                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    orc.SetlifePoints(orc.GetlifePoints() + ((orc.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    orc.SetManaPoints(orc.GetManaPoints() + ((orc.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 28% physical damage points depends the enemy's level
                                                                    orc.SetPhysicalDamage(orc.GetPhysicalDamage() + ((orc.GetPhysicalDamage() * enemyLevel) / 7));
                                                                    //Upgrade 16% magic damage points depends the enemy's level
                                                                    orc.SetMagicDamage(orc.GetMagicDamage() + ((orc.GetMagicDamage() * enemyLevel) / 12));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    orc.SetAttackSpeed(orc.GetAttackSpeed() + ((orc.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    orc.SetCelerity(orc.GetCelerity() + ((orc.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    orc.SetSpecialMoveDamage(orc.GetSpecialMoveDamage() + ((orc.GetSpecialMoveDamage() * enemyLevel) / 20));


                                                                }
                                                                Console.Clear();

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a orc level {orc.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {wizard.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The Orc has {orc.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (wizard.GetlifePoints() > 0 && orc.GetlifePoints() > 0)
                                                                {
                                                                    Console.Clear();

                                                                    Console.WriteLine($"Orc's has : {orc.GetlifePoints()} life points and {orc.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {wizard.GetlifePoints()} life points and {wizard.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackPhysicalDamagePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackPhysicalDamagePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackMagicDamagePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackMagicDamagePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackSpecialMovePJ(orc);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackSpecialMovePJ(orc);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > orc.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        orc.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        orc.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        orc.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }

                                                                }

                                                                //When the character lose the battle
                                                                if (wizard.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable orc beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameWizard = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless orc and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    wizard.SetHealPotions(wizard.GetHealPotions() + potionToReceive);
                                                                    wizard.SetManaPotions(wizard.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Orc bone", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    wizardInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    wizard.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }


                                                            //Banshee
                                                            else if (enemyType == 2)
                                                            {
                                                                NPCBanshee banshe = new(50, 120, enemyLevel, 10, 20, 10, 10, "Mournful wail", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {
                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    banshe.SetlifePoints(banshe.GetlifePoints() + ((banshe.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    banshe.SetManaPoints(banshe.GetManaPoints() + ((banshe.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 16% physical damage points depends the enemy's level
                                                                    banshe.SetPhysicalDamage(banshe.GetPhysicalDamage() + ((banshe.GetPhysicalDamage() * enemyLevel) / 12));
                                                                    //Upgrade 28% magic damage points depends the enemy's level
                                                                    banshe.SetMagicDamage(banshe.GetMagicDamage() + ((banshe.GetMagicDamage() * enemyLevel) / 7));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    banshe.SetAttackSpeed(banshe.GetAttackSpeed() + ((banshe.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    banshe.SetCelerity(banshe.GetCelerity() + ((banshe.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    banshe.SetSpecialMoveDamage(banshe.GetSpecialMoveDamage() + ((banshe.GetSpecialMoveDamage() * enemyLevel) / 20));
                                                                }
                                                                Console.Clear();

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a banshee level {banshe.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {wizard.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The banshee has {banshe.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (wizard.GetlifePoints() > 0 && banshe.GetlifePoints() > 0)
                                                                {
                                                                    //Ataques ya estan hechos, fisico magico y especial
                                                                    //tomar posion vida y mana

                                                                    //Agregar items al inventario
                                                                    //Una vez terminado con el banshee debemos hacer lo mismo en los otros

                                                                    Console.Clear();

                                                                    Console.WriteLine($"Banshee's has : {banshe.GetlifePoints()} life points and {banshe.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {wizard.GetlifePoints()} life points and {wizard.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackPhysicalDamagePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackPhysicalDamagePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackMagicDamagePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackMagicDamagePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackSpecialMovePJ(banshe);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackSpecialMovePJ(banshe);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > banshe.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        banshe.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        banshe.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        banshe.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }

                                                                }

                                                                //When the character lose the battle
                                                                if (wizard.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable skull warrior beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameWizard = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless banshee and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    wizard.SetHealPotions(wizard.GetHealPotions() + potionToReceive);
                                                                    wizard.SetManaPotions(wizard.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Banshee cloth shard", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    wizardInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    wizard.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }


                                                            //Skull warrior
                                                            else if (enemyType == 3)
                                                            {
                                                                NPCSkull skullWarrior = new(30, 50, enemyLevel, 15, 0, 15, 10, "Gore charge", 40);

                                                                //Change the stats depends the enemyLevel
                                                                if (enemyLevel > 1)
                                                                {
                                                                    //Upgrade 33% life points depends the enemy's level
                                                                    skullWarrior.SetlifePoints(skullWarrior.GetlifePoints() + ((skullWarrior.GetlifePoints() * enemyLevel) / 6));
                                                                    //Upgrade 33% mana points depends the enemy's level
                                                                    skullWarrior.SetManaPoints(skullWarrior.GetManaPoints() + ((skullWarrior.GetManaPoints() * enemyLevel) / 6));
                                                                    //Upgrade 28% physical damage points depends the enemy's level
                                                                    skullWarrior.SetPhysicalDamage(skullWarrior.GetPhysicalDamage() + ((skullWarrior.GetPhysicalDamage() * enemyLevel) / 7));
                                                                    //Upgrade 16% magic damage points depends the enemy's level
                                                                    skullWarrior.SetMagicDamage(skullWarrior.GetMagicDamage() + ((skullWarrior.GetMagicDamage() * enemyLevel) / 12));
                                                                    //Upgrade 10% attack speed points depends the enemy's level
                                                                    skullWarrior.SetAttackSpeed(skullWarrior.GetAttackSpeed() + ((skullWarrior.GetAttackSpeed() * enemyLevel) / 20));
                                                                    //Upgrade 10% celerity points depends the enemy's level
                                                                    skullWarrior.SetCelerity(skullWarrior.GetCelerity() + ((skullWarrior.GetCelerity() * enemyLevel) / 20));
                                                                    //Upgrade 16% special move damage  points depends the enemy's level
                                                                    skullWarrior.SetSpecialMoveDamage(skullWarrior.GetSpecialMoveDamage() + ((skullWarrior.GetSpecialMoveDamage() * enemyLevel) / 20));
                                                                }

                                                                Console.WriteLine($"Continuing with your journey inside the mazmorra, you find yourself with a banshee level {skullWarrior.GetLevel()}, who faces you in a challenging battle.");
                                                                Console.WriteLine();
                                                                Console.WriteLine($"Our hero has {wizard.GetlifePoints()} life's points.");
                                                                Console.WriteLine($"The Banshee has {skullWarrior.GetlifePoints()} life's points.");
                                                                Console.WriteLine();

                                                                //While one of fighters have life
                                                                while (wizard.GetlifePoints() > 0 && skullWarrior.GetlifePoints() > 0)
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine($"Skull warrior's has : {skullWarrior.GetlifePoints()} life points and {skullWarrior.GetManaPoints()} mana points.");
                                                                    Console.WriteLine($"You have : {wizard.GetlifePoints()} life points and {wizard.GetManaPoints()} mana points");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("[1] Physical attack");
                                                                    Console.WriteLine("[2] Magic attack (Mana -10)");
                                                                    Console.WriteLine("[3] Special move attack (Mana -15)");
                                                                    Console.WriteLine("[4] Use heal potion");
                                                                    Console.WriteLine("[5] Use mana potion");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Note: If you try to use an attack that uses mana or use positions but you don't have it, it will be considered as a turn over without performing any concrete action..");
                                                                    Console.WriteLine();
                                                                    Console.Write("Select a choice from the menu: ");
                                                                    currentlyBAttleOptions = int.Parse(Console.ReadLine());
                                                                    switch (currentlyBAttleOptions)
                                                                    {


                                                                        //------------ Physical  attack --------------
                                                                        case 1:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackPhysicalDamagePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackPhysicalDamagePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Physical  attack --------------


                                                                        //------------ Magic attack --------------
                                                                        case 2:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackMagicDamagePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackMagicDamagePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Magic attack --------------



                                                                        //------------ Special move attack --------------
                                                                        case 3:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.AttackSpecialMovePJ(skullWarrior);

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.AttackSpecialMovePJ(skullWarrior);

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Special move attack --------------



                                                                        //------------ Use heal potion --------------
                                                                        case 4:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.DrinkHealPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.DrinkHealPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use heal potion --------------


                                                                        //------------ Use mana potion --------------
                                                                        case 5:
                                                                            Console.Clear();

                                                                            //Depends the celerity of the character
                                                                            if (wizard.GetCelerity() > skullWarrior.GetCelerity())
                                                                            {
                                                                                //Hero
                                                                                wizard.DrinkManaPotion();

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                                //Enemy
                                                                                Random random = new Random();
                                                                                int attackType = random.Next(3);
                                                                                switch (attackType)
                                                                                {
                                                                                    case 0:
                                                                                        skullWarrior.AttackPhysicalDamageNPC(wizard);
                                                                                        break;
                                                                                    case 1:
                                                                                        skullWarrior.AttackMagicDamageNPC(wizard);
                                                                                        break;
                                                                                    case 2:
                                                                                        skullWarrior.AttackSpecialMoveNPC(wizard);
                                                                                        break;
                                                                                }

                                                                                //Hero
                                                                                wizard.DrinkManaPotion();

                                                                            }

                                                                            Console.Write("Press any key to return to continue ");
                                                                            Console.ReadLine();

                                                                            break;
                                                                        //------------ Use mana potion --------------

                                                                        default:
                                                                            Console.Clear();
                                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                                            break;
                                                                    }


                                                                }

                                                                //When the character lose the battle
                                                                if (wizard.GetlifePoints() <= 0)
                                                                {
                                                                    Console.WriteLine("The implacable skull warrior beats you this time and your adventure through the mazmorra reaches its end.");
                                                                    Console.WriteLine();
                                                                    Console.Write("Game over.");
                                                                    Console.WriteLine();
                                                                    Console.Write("You can play again from the last saved point, just remember to load the correct file. Press any key to return to the main menu ");
                                                                    Console.ReadLine();
                                                                    battleMenuOptions = 4;
                                                                    storyOptions = 7;
                                                                    currentlyGameWizard = 1;
                                                                    optionSubMenu = 4;
                                                                }

                                                                //When the character win the battle
                                                                else
                                                                {

                                                                    Console.Clear();

                                                                    Console.WriteLine("After a relentless battle, you could win the relentless skull warrior and continue with your crossing");

                                                                    //Add experience to the character (for win)
                                                                    int experienceReceived = 100 * enemyLevel;
                                                                    Console.WriteLine();
                                                                    Console.WriteLine($"You received {experienceReceived} experience points after this battle.");

                                                                    //Add potions to the character (for win)
                                                                    int potionToReceive = 1 * enemyLevel;
                                                                    wizard.SetHealPotions(wizard.GetHealPotions() + potionToReceive);
                                                                    wizard.SetManaPotions(wizard.GetManaPotions() + potionToReceive);
                                                                    Console.WriteLine($"You received {potionToReceive} potions of life and mana after this battle.");
                                                                    Console.WriteLine();

                                                                    //Add item to the inventory
                                                                    Item item = new("Jaw bone", 1);
                                                                    Console.WriteLine($"You have collected {item.GetName()} to add to your spoils of war.");
                                                                    wizardInventory.AddItemToInventory(item);

                                                                    //Add experience to win the battle & lvl up if necessary
                                                                    wizard.AddExperience(enemyLevel);

                                                                    Console.WriteLine();
                                                                    //Return to main menu
                                                                    Console.WriteLine("Press any key to return to main menu");
                                                                    Console.ReadLine();
                                                                }
                                                            }

                                                            break;
                                                        //--------- Battle Start ------------


                                                        //--------- Custom enemy's type ------------
                                                        case 2:
                                                            string enemyTypeString = ""; //Variable to help the user to show the enemy's type

                                                            Console.Clear();
                                                            Console.WriteLine();
                                                            Console.WriteLine("[1] Orc");
                                                            Console.WriteLine("[2] Banshe");
                                                            Console.WriteLine("[3] Skull warrior");
                                                            Console.WriteLine("[4] Return to main menu");
                                                            Console.WriteLine();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomType = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomType, out int customType))
                                                            {
                                                                if (settingCustomType == "1") { enemyTypeString = "orc"; }
                                                                else if (settingCustomType == "2") { enemyTypeString = "banshe"; }
                                                                else if (settingCustomType == "3") { enemyTypeString = "skull warrior"; }

                                                                Console.WriteLine($"The type was changed to {enemyTypeString} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyType = customType;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's type - End --------


                                                        //--------- Custom enemy's level ------------
                                                        case 3:
                                                            Console.Clear();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomLevel = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomLevel, out int customLevel))
                                                            {
                                                                Console.WriteLine($"The level was changed to {customLevel} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyLevel = customLevel;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's level - End --------


                                                        case 4:
                                                            storyOptions = 0;
                                                            break;


                                                        default:
                                                            Console.Clear();
                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                            break;
                                                    }
                                                }
                                                break;
                                            //------------ "[1] Battle - End"  --------------- 

                                            //----------------- "[2] Stats"  ---------------- 
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine(wizard.GetAllStats());
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[2] Stats - End"  -------------- 



                                            //----------------- "[3] Inventory"  ---------------- 
                                            case 3:
                                                Console.Clear();
                                                wizardInventory.Display();
                                                Console.WriteLine();
                                                Console.WriteLine($"Heal potions: {wizard.GetHealPotions()}");
                                                Console.WriteLine($"Mana potions: {wizard.GetManaPotions()}");
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[3] Inventory - End"  -------------- 


                                            //----------------- "[4] Upgrade skills"  ---------------- 
                                            case 4:
                                                Console.Clear();
                                                wizard.UpgradeSkills(wizard.GetPointsToAssign());
                                                break;
                                            //------------- "[4] Upgrade skills - End"  -------------- 


                                            //------------------ "[5] Save Stats"  ------------------- 
                                            case 5:
                                                Console.Clear();
                                                Console.Write("What is the filename for the game file (ex: GameSavedFile.csv)? ");
                                                string fileName = Console.ReadLine();
                                                using (StreamWriter outputFile = new StreamWriter(fileName))
                                                {
                                                    // You can add userExperiencePoints in the moment
                                                    // You can add userPointsToAssign in the moment
                                                    outputFile.WriteLine(wizard.GetExperiencePoints());
                                                    outputFile.WriteLine(wizard.GetPointsToAssign());


                                                    //Save the current stats
                                                    outputFile.WriteLine(wizard.GetlifePoints());
                                                    outputFile.WriteLine(wizard.GetManaPoints());
                                                    outputFile.WriteLine(wizard.GetExperiencePoints());
                                                    outputFile.WriteLine(wizard.GetPointsToAssign());
                                                    outputFile.WriteLine(wizard.GetLevel());
                                                    outputFile.WriteLine(wizard.GetHealPotions());
                                                    outputFile.WriteLine(wizard.GetManaPotions());
                                                    outputFile.WriteLine(wizard.GetPhysicalDamage());
                                                    outputFile.WriteLine(wizard.GetMagicDamage());
                                                    outputFile.WriteLine(wizard.GetAttackSpeed());
                                                    outputFile.WriteLine(wizard.GetCelerity());
                                                    outputFile.WriteLine(wizard.GetSpecialMoveTitle());
                                                    outputFile.WriteLine(wizard.GetSpecialMoveDamage());

                                                    //For each item inside the list, save a line with different formats(override in the class)
                                                    foreach (var item in wizardInventory._items)
                                                    {
                                                        //Save all the items inside the list
                                                        outputFile.WriteLine(item._name + "," + item._quantity);

                                                    }


                                                }
                                                break;
                                            //------------------ "[5] Save Stats"- End --------------- 


                                            //------------------ "[6] Load Stats"- End --------------- 
                                            case 6:
                                                Console.Clear();
                                                //Charge the information
                                                wizard.ChargeInformation(wizard, userExperiencePoints, userPointsToAssign, wizardInventory);
                                                break;
                                            //------------------ "[6] Load Stats"- End --------------- 


                                            //--------------- [7] Quit ---------------------
                                            case 7:
                                                currentlyGameWizard = 1;
                                                break;
                                            //--------------- [7] Quit ---------------------


                                            default:
                                                Console.WriteLine("Wrong.Choose another option");
                                                break;
                                        }

                                        //Finish the program (close all the loops)
                                        optionSubMenu = 4;
                                        option = 3;
                                        break;
                                    }
                                }
                                break;

                            //--- "[3] Wizard - End" --- 


                            //--- "[4] Return to main menu"  --- 
                            case 4:
                                break;
                            //--- "[4] Return to main menu - End" --- 

                            default:
                                Console.Clear();
                                Console.WriteLine("Wrong. Please choose another option.");
                                break;
                        }
                    }
                    break;
                //-------------- "[1] New game - End"  ------------------ 

                case 2:

                    chargedOptions = 0;
                    Console.Clear();

                    while (chargedOptions != 4)
                    {

                        //Charge the information
                        Console.Clear();
                        Console.WriteLine("Dungeon of the underworld");
                        Console.WriteLine();
                        Console.WriteLine("[1] Archer");
                        Console.WriteLine("[2] Knight");
                        Console.WriteLine("[3] Wizard");
                        Console.WriteLine("[4] Return to main menu");
                        Console.WriteLine();
                        Console.Write("Select a choice from the menu: ");

                        int chargedStoryOption = int.Parse(Console.ReadLine());

                        switch (chargedStoryOption)
                        {
                            case 1:

                                bool testArcherGameLoad = false;
                                testArcherGameLoad = archer.ChargeInformation(archer, userExperiencePoints, userPointsToAssign, archerInventory);

                                //If the method ChargeInformation return true change all the variables
                                if (testArcherGameLoad)
                                {
                                    chargedOptions = 4;
                                    fileCharged = true;
                                    PJToLoad = "archer";
                                }

                                break;

                            case 2:

                                bool testKnightGameLoad = false;
                                testKnightGameLoad = knight.ChargeInformation(knight, userExperiencePoints, userPointsToAssign, knightInventory);

                                //If the method ChargeInformation return true change all the variables
                                if (testKnightGameLoad)
                                {
                                    chargedOptions = 4;
                                    fileCharged = true;
                                    PJToLoad = "knight";

                                }

                                break;

                            case 3:

                                bool testWizardGameLoad = false;
                                testWizardGameLoad = wizard.ChargeInformation(wizard, userExperiencePoints, userPointsToAssign, wizardInventory);

                                //If the method ChargeInformation return true change all the variables
                                if (testWizardGameLoad)
                                {
                                    chargedOptions = 4;
                                    fileCharged = true;
                                    PJToLoad = "wizard";

                                }
                                break;

                            case 4:

                                //The flow turns different depends the fileCharged
                                if (fileCharged)
                                {
                                    fileCharged = true;
                                    chargedOptions = 4;
                                }

                                else
                                {
                                    fileCharged = false;
                                    chargedOptions = 4;
                                }

                                break;

                            default:

                                Console.Clear();
                                Console.WriteLine("Wrong. Please choose another option.");
                                break;
                        }
                    }

                    break;

                //------------------ "[3] Quit"  ------------------------ 
                case 3:
                    break;
                //------------------ "[3] Quit" - End ------------------- 

                //Default case (when the user wrong) 
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }
        }
    }
    
}