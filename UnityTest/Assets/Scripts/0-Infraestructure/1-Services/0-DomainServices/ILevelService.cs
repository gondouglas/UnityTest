using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelService {

    int CurrentLevel();
    int CurrentExperience();
    int UpdateNextLevelExperience();
    bool AddExperience(int exp);
    void LevelUp();

}
