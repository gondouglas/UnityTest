﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacterService : MonoBehaviour, IBaseCharacterService  {


    public abstract BaseCharacter GetCharacter();
    public abstract BaseRace GetRace();

	// Use this for initialization
	protected void Start () {
        GetCharacter().BasicAttribute = GetRace().GetRacialBasicAttribute(GetCharacter().BasicAttribute);
        GetCharacter().Proficiency = GetRace().GetRacialProficiency(GetCharacter().Proficiency);

    }
	
	// Update is called once per frame
	protected void Update () {
		
	}

    public void ApplyDamage(DomainType domain, float damage) {
        int defense = GetCharacter().Proficiency.GetDomain(domain).Defense.CurrentLevel;
        if (defense != 0) {
            damage = damage / defense;
        }
        GetCharacter().BasicAttribute.CurrentHP -= damage;
        GetCharacter().Proficiency.GetDomain(domain).Defense.AddExperience((int)damage);
    }
}
