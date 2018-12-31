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
    } 

    public int CurrentExperience {
        get { return _CurrentExperience; }
        private set { _CurrentExperience = value; }
    } 

    public int FirstLevelExperience {
        get { return _FirstLevelExperience; }
        set { _FirstLevelExperience = value; }
    } 

    public int NextLevelExperience {
        get { return _NextLevelExperience; }
        set { _NextLevelExperience = value; }
    } 

    public float ScaleFactor {
        get { return _ScaleFactor; }
        set { _ScaleFactor = value; }
    } 


    /// <summary>
    /// Aualiza a experiência do proximo nível
    /// </summary>
    /// <returns>experiência do proxímo nível</returns>
    public int UpdateNextLevelExperience()
    {
        this.NextLevelExperience = Convert.ToInt32(this.CurrentLevel * this.ScaleFactor * this.FirstLevelExperience);

        return this.NextLevelExperience;
    }

    /// <summary>
    /// Adiciona uma quantidade de experiência verificando se passou de nível
    /// </summary>
    /// <param name="exp">experiência a ser adicionada</param>
    /// <returns>Retorna verdadeiro se subir de nível e falso se não subir</returns>
    public bool AddExperience(int exp)
    {

        this.CurrentExperience += exp;

        //experiência atual é maior ou igual ao necessário para subir de nível
        if (this.CurrentExperience >= this.NextLevelExperience)
        {

            //remove a quantidade necessária da experiência atual
            this.CurrentExperience -= this.NextLevelExperience;

            //Sobe de nível
            LevelUp();
            return true;
        }

        return false;
    }

    /// <summary>
    /// Sobe de nível
    /// </summary>
    public void LevelUp()
    {
        this.CurrentLevel++;
        UpdateNextLevelExperience();
    }
}
