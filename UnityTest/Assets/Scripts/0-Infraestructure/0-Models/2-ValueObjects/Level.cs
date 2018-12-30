using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe que representa o nível do objeto
/// </summary>
[Serializable]
public class Level {

    private int _CurrentLevel;
    private int _CurrentExperience;
    private int _FirstLevelExperience;
    private int _NextLevelExperience;
    private float _ScaleFactor;

    public int CurrentLevel
    {
        get { return _CurrentLevel; }
        set { _CurrentLevel = value;  }
    } //nível atual
    public int CurrentExperience {
        get { return _CurrentExperience; }
        set { _CurrentExperience = value; }
    } //experiência atual
    public int FirstLevelExperience {
        get { return _FirstLevelExperience; }
        set { _FirstLevelExperience = value; }
    } //experiência do primeiro nível
    public int NextLevelExperience {
        get { return _NextLevelExperience; }
        set { _NextLevelExperience = value; }
    } //experiência do próximo nível
    public float ScaleFactor {
        get { return _ScaleFactor; }
        set { _ScaleFactor = value; }
    } //fator de escala para calculo da experiência do próximo nível
}
