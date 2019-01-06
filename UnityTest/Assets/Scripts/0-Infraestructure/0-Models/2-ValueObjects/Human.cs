using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : BaseRace
{
    public override BasicAttributes GetRacialBasicAttribute(BasicAttributes basicAttribute)
    {
        basicAttribute.Level.CurrentLevel = 1;
        basicAttribute.Level.FirstLevelExperience = 150;
        basicAttribute.Level.ScaleFactor = 1.7534f;
        basicAttribute.MaxHP = 35;
        basicAttribute.MaxSP = 30;
        basicAttribute.MaxMP = 0;
        basicAttribute.CurrentHP = basicAttribute.MaxHP;
        basicAttribute.CurrentSP = basicAttribute.MaxSP;
        basicAttribute.CurrentMP = basicAttribute.MaxMP;
        basicAttribute.StrengthBase = 1;
        basicAttribute.DexterityBase = 1;
        basicAttribute.ConstitutionBase = 1;
        basicAttribute.IntelligenceBase = 1;
        basicAttribute.WisdomBase = 1;
        basicAttribute.CharismaBase = 1;

        return basicAttribute;
    }

    public override Proficiency GetRacialProficiency(Proficiency proficiency)
    {
        return proficiency;
    }
}
