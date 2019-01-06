using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base para todos os personagens
/// </summary>
[Serializable]
public abstract class BaseCharacter {

    public BaseRace Race { get; set; }

    private BasicAttributes _BasicAttributes = new BasicAttributes();
    
    public BasicAttributes BasicAttributes {
        get
        {
            return _BasicAttributes;
        }
        set
        {
            _BasicAttributes = value;
        }
    }

    private Proficiency _Proficiency = new Proficiency();

    public Proficiency Proficiency {
        get
        {
            return _Proficiency;
        }
        set
        {
            _Proficiency = value;
        }
    }
}
