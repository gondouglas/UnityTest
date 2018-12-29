using System;
/// <summary>
/// Atributos básicos para um personagem
/// </summary
[Serializable]
public class BasicAttribute {

    public int maxHP;
    public int maxSP;
    public int maxMP;

    private float CurrentHP;
    private float CurrentSP;
    private float CurrentMP;
}
