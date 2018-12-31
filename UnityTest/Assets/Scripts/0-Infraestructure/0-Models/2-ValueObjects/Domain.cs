using System;
/// <summary>
/// Dominios de um personagem
/// </summary>
[Serializable]
public class Domain {

    public DomainType DomainType;

    public Domain(DomainType domain)
    {
        DomainType = domain;
    }

    private Level _Attack = new Level();

    public Level Attack
    {
        get
        {
            return _Attack;
        }
        set
        {
            _Attack = value;
        }
    }

    private Level _Defense = new Level();

    public Level Defense
    {
        get
        {
            return _Defense;
        }
        set
        {
            _Defense = value;
        }
    }
}
