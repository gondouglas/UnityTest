using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Proficiências de um personagem
/// </summary>
[Serializable]
public class Proficiency {

    private Domain _Slash = new Domain(DomainType.SLASH);
    private Domain _Thrust = new Domain(DomainType.THRUST);
    private Domain _Smash = new Domain(DomainType.SMASH);
    private Domain _Fire = new Domain(DomainType.FIRE);
    private Domain _Water = new Domain(DomainType.WATER);
    private Domain _Earth = new Domain(DomainType.EARTH);
    private Domain _Wind = new Domain(DomainType.WIND);
    private Domain _Mind = new Domain(DomainType.MIND);
    private Domain _Light = new Domain(DomainType.LIGHT);
    private Domain _Dark = new Domain(DomainType.DARK);
    private Domain _Nature = new Domain(DomainType.NATURE);
    private Domain _Divine = new Domain(DomainType.DIVINE);

    public Domain Slash
    {
        get
        {
            return _Slash;
        }
        set
        {
            _Slash = value;
        }
    }

    public Domain Thrust
    {
        get
        {
            return _Thrust;
        }
        set
        {
            _Thrust = value;
        }
    }

    public Domain Smash
    {
        get
        {
            return _Smash;
        }
        set
        {
            _Smash = value;
        }
    }

    public Domain Fire
    {
        get
        {
            return _Fire;
        }
        set
        {
            _Fire = value;
        }
    }

    public Domain Water
    {
        get
        {
            return _Water;
        }
        set
        {
            _Water = value;
        }
    }

    public Domain Earth
    {
        get
        {
            return _Earth;
        }
        set
        {
            _Earth = value;
        }
    }

    public Domain Wind
    {
        get
        {
            return _Wind;
        }
        set
        {
            _Wind = value;
        }
    }

    public Domain Mind
    {
        get
        {
            return _Mind;
        }
        set
        {
            _Mind = value;
        }
    }

    public Domain Light
    {
        get
        {
            return _Light;
        }
        set
        {
            _Light = value;
        }
    }

    public Domain Dark
    {
        get
        {
            return _Dark;
        }
        set
        {
            _Dark = value;
        }
    }

    public Domain Nature
    {
        get
        {
            return _Nature;
        }
        set
        {
            _Nature = value;
        }
    }

    public Domain Divine
    {
        get
        {
            return _Divine;
        }
        set
        {
            _Divine = value;
        }
    }

}
