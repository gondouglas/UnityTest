using System;
/// <summary>
/// Atributos básicos para um personagem
/// </summary
[Serializable]
public class BasicAttributes {

    public int MaxHP;
    public int MaxSP;
    public int MaxMP;

    public float CurrentHP;
    public float CurrentSP;
    public float CurrentMP;

    public int StrengthBase;
    public int StrengthMod;

    public int DexterityBase;
    public int DexterityMod;

    public int ConstitutionBase;
    public int ConstitutionMod;

    public int IntelligenceBase;
    public int IntelligenceMod;

    public int WisdomBase;
    public int WisdomMod;

    public int CharismaBase;
    public int CharismaMod;


    public int Strength {
        get { return StrengthBase + StrengthMod; }
    }
    public int Dexterity {
        get { return DexterityBase + DexterityMod; }
    }
    public int Constitution {
        get { return ConstitutionBase + ConstitutionMod; }
    }
    public int Intelligence {
        get { return IntelligenceBase + IntelligenceMod; }
    }
    public int Wisdom {
        get { return WisdomBase + WisdomMod; }
    }
    public int Charisma {
        get { return CharismaBase + CharismaMod; }
    }

    private Level _Level = new Level();

    public Level Level {
        get
        {
            return _Level;
        }
        set
        {
            _Level = value;
        }
    }
}
