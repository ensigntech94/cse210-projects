using System;
//Public class to can use in "other window"

// this class must also be declared as an abstract class (because have an abstract method inside).
public abstract class BaseNPCharacter
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    public int _life;
    protected int _mana;
    protected int _lvl; //Determine the skills
    public int _physicalDamage; //Determine strengh of hit
    public int _magicDamage; //Magical power (spells)
    public int _attackSpeed; //Posibility to do "combos" (2 hits in the same turn for example)
    protected int _celerity; //Determine who start in the battle (speed to do the first attack)
    protected string _specialMoveTitle;
    public int _specialMoveDamage;

    //----------- Constructors section (templates)--------------

    //The default BaseNPCharacter when we create
    public BaseNPCharacter()
    {
        //Default values
        _life = 1;
        _mana = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 1 parameter
    public BaseNPCharacter(int lifePoints)
    {

        _life = lifePoints;
        _mana = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 2 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 3 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 4 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 5 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = 0;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 6 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 7 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 8 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = 0;
    }
    //When the user put 9 parameters
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle, int specialMoveDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = specialMoveDamage;
    }


    //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public int GetlifePoints()
    {
        //See the value of _life
        return _life;
    }
    public void SetlifePoints(int lifePoints)
    {
        //Put the value of _life
        _life = lifePoints;
    }

    public int GetManaPoints()
    {
        //See the value of _mana
        return _mana;
    }
    public void SetManaPoints(int manaPoints)
    {
        //Put the value of _mana
        _mana = manaPoints;
    }
    public int GetLevel()
    {
        //See the value of _lvl
        return _lvl;
    }
    public void SetLevel(int level)
    {
        //Put the value of _lvl
        _lvl = level;
    }

    public int GetPhysicalDamage()
    {
        //See the value of _life
        return _physicalDamage;
    }
    public void SetPhysicalDamage(int physicalDamage)
    {
        //Put the value of _life
        _physicalDamage = physicalDamage;
    }

    public int GetMagicDamage()
    {
        //See the value of _magicDamage
        return _magicDamage;
    }
    public void SetMagicDamage(int magicDamage)
    {
        //Put the value of _magicDamage
        _magicDamage = magicDamage;
    }

    public int GetAttackSpeed()
    {
        //See the value of _attackSpeed
        return _attackSpeed;
    }
    public void SetAttackSpeed(int attackSpeed)
    {
        //Put the value of _attackSpeed
        _attackSpeed = attackSpeed;
    }

    public int GetCelerity()
    {
        //See the value of _celerity
        return _celerity;
    }
    public void SetCelerity(int celerity)
    {
        //Put the value of _celerity
        _celerity = celerity;
    }
    public string GetSpecialMoveTitle()
    {
        //See the value of _specialMoveTitle
        return _specialMoveTitle;
    }
    public void SetSpecialMoveTitle(string specialMoveTitle)
    {
        //Put the value of _specialMoveTitle
        _specialMoveTitle = specialMoveTitle;
    }
    public int GetSpecialMoveDamage()
    {
        //See the value of _specialMoveDamage
        return _specialMoveDamage;
    }
    public void SetSpecialMoveDamage(int specialMoveDamage)
    {
        //Put the value of _specialMoveDamage
        _specialMoveDamage = specialMoveDamage;
    }
    //----------------- Getter & Setter section -----------------
    //------------------------- Methods -------------------------

    //Function to attack (Physical)
    public void AttackPhysicalDamageNPC(Object objetive)
    {

        if (objetive is PJArcher)
        {
            ((PJArcher)objetive)._life -= _physicalDamage;
        }
        if (objetive is PJKnight)
        {
            ((PJKnight)objetive)._life -= _physicalDamage;
        }
        if (objetive is PJWizard)
        {
            ((PJWizard)objetive)._life -= _physicalDamage;
        }

        Console.WriteLine($"Our enemy attacks inflicts {_physicalDamage} points of physical damage on our hero.");
        Console.WriteLine();


    }

    //Function to attack (Magic)
    public void AttackMagicDamageNPC(Object objetive)
    {
        if (_mana >= 10)
        {
            if (objetive is PJArcher)
            {
                ((PJArcher)objetive)._life -= _magicDamage;
                _mana -= 10;
            }
            if (objetive is PJKnight)
            {
                ((PJKnight)objetive)._life -= _magicDamage;
                _mana -= 10;
            }
            if (objetive is PJWizard)
            {
                ((PJWizard)objetive)._life -= _magicDamage;
                _mana -= 10;
            }

            Console.WriteLine($"Our enemy attacks inflicts {_magicDamage} points of magic damage on our hero.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Our enemy doesn't have enough mana. It lose it turn to attack.");
            Console.WriteLine();

        }
    }

    //Function to attack (Special move)
    public void AttackSpecialMoveNPC(Object objetive)
    {
        if (_mana >= 15)
        {
            if (objetive is PJArcher)
            {
                ((PJArcher)objetive)._life -= _specialMoveDamage;
                _mana -= 15;
            }
            if (objetive is PJKnight)
            {
                ((PJKnight)objetive)._life -= _specialMoveDamage;
                _mana -= 15;
            }
            if (objetive is PJWizard)
            {
                ((PJWizard)objetive)._life -= _specialMoveDamage;
                _mana -= 15;
            }

            Console.WriteLine($"Our enemy attacks inflicts {_magicDamage} points of magic damage on our hero.");
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Our enemy doesn't have enough mana. It lose it turn to attack.");
            Console.WriteLine();

        }
    }



}
