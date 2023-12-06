using System;
//Public class to can use in "other window"

public class NPCOrc : BaseNPCharacter // NPCOrc child class of BaseNPCharacter
{
        //Protect class inside the propieties to not affect the working of the program (only the inherit class)
        //protected int _life;
        //protected int _mana;
        //protected int _lvl; //Determine the skills
        //protected int _physicalDamage; //Determine strengh of hit
        //protected int _magicDamage; //Magical power (spells)
        //protected int _attackSpeed; //Posibility to do "combos" (2 hits in the same turn for example)
        //protected int _celerity; //Determine who start in the battle (speed to do the first attack)
        //private string _specialMoveTitle;
        //private int _specialMoveDamage;

        //----------- Constructors section (templates)--------------

        //The default NPCOrc when we create
        public NPCOrc(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity) :base(lifePoints,manaPoints,level,physicalDamage,magicDamage,attackSpeed,celerity)
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

     //With 1 parameters
     public NPCOrc(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle) :base(lifePoints,manaPoints,level,physicalDamage,magicDamage,attackSpeed,celerity)
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

    //With 2 parameters
     public NPCOrc(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle, int specialMoveDamage) :base(lifePoints,manaPoints,level,physicalDamage,magicDamage,attackSpeed,celerity)
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
}