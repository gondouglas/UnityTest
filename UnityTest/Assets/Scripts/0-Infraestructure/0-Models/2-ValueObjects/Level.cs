using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe que representa o nível do objeto
/// </summary>
public class Level {

    public int CurrentLevel { get; set; } //nível atual
    public int CurrentExperience { get; set; } //experiência atual
    public int FirstLevelExperience { get; set; } //experiência do primeiro nível
    public int NextLevelExperience { get; set; } //experiência do próximo nível
    public float ScaleFactor { get; set; } //fator de escala para calculo da experiência do próximo nível
}
