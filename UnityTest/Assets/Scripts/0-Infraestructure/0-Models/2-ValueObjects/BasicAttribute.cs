using System;
/// <summary>
/// Atributos básicos para um personagem
/// </summary
[Serializable]
public class BasicAttribute {

    public int MaxHP { get; set; }
    public int MaxSP { get; set; }
    public int MaxMP { get; set; }

    public float CurrentHP { get; set; }
    public float CurrentSP { get; set; }
    public float CurrentMP { get; set; }

    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

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
