using System;
/// <summary>
/// Basic attributes for a character
/// </summary
[Serializable]
public class BasicAttribute {

    public int maxHP;
    public int maxSP;
    public int maxMP;

    private float CurrentHP { get; set; }
    private float CurrentSP { get; set; }
    private float CurrentMP { get; set; }
}
