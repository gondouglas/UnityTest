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

    private Level _Level = new Level();

    public Level Level
    {
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
