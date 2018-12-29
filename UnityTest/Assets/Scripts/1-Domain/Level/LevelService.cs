using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelService : ILevelService {

    Level Level { get; set; }

    /// <summary>
    /// Recupera o nível atual
    /// </summary>
    /// <returns>nível atual</returns>
    public int CurrentLevel()
    {
        return Level.CurrentLevel;
    }

    /// <summary>
    /// Recupera a experiência atual
    /// </summary>
    /// <returns>experiência atual</returns>
    public int CurrentExperience()
    {
        return Level.CurrentExperience;
    }

    /// <summary>
    /// Aualiza a experiência do proximo nível
    /// </summary>
    /// <returns>experiência do proxímo nível</returns>
    public int UpdateNextLevelExperience()
    {
        Level.NextLevelExperience = Convert.ToInt32(Level.CurrentLevel * Level.ScaleFactor * Level.FirstLevelExperience);

        return Level.NextLevelExperience;
    }

    /// <summary>
    /// Adiciona uma quantidade de experiência verificando se passou de nível
    /// </summary>
    /// <param name="exp">experiência a ser adicionada</param>
    /// <returns>Retorna verdadeiro se subir de nível e falso se não subir</returns>
    public bool AddExperience(int exp)
    {

        Level.CurrentExperience += exp;

        //experiência atual é maior ou igual ao necessário para subir de nível
        if (Level.CurrentExperience >= Level.NextLevelExperience)
        {

            //remove a quantidade necessária da experiência atual
            Level.CurrentExperience -= Level.NextLevelExperience;

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
        Level.CurrentLevel++;
        UpdateNextLevelExperience();
    }

}
