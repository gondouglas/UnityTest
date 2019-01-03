﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : BaseRace
{
    public override BasicAttribute GetRacialBasicAttribute(BasicAttribute basicAttribute)
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
        basicAttribute.Strength = 1;
        basicAttribute.Dexterity = 1;
        basicAttribute.Constitution = 1;
        basicAttribute.Intelligence = 1;
        basicAttribute.Wisdom = 1;
        basicAttribute.Charisma = 1;

        return basicAttribute;
    }

    public override Proficiency GetRacialProficiency(Proficiency proficiency)
    {
        return proficiency;
    }
}
