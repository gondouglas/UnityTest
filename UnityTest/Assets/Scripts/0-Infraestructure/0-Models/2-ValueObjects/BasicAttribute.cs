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
