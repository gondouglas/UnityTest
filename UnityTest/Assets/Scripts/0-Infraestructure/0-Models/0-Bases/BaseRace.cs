using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseRace
{
    public abstract Proficiency GetRacialProficiency(Proficiency proficiency);
    public abstract BasicAttribute GetRacialBasicAttribute(BasicAttribute basicAttribute);
}
