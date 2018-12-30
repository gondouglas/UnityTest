using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base para todos os personagens
/// </summary>
[Serializable]
public abstract class BaseCharacter {

    private BasicAttribute _BasicAttribute = new BasicAttribute();
    
    public BasicAttribute BasicAttribute {
        get
        {
            return _BasicAttribute;
        }
        set
        {
            _BasicAttribute = value;
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
