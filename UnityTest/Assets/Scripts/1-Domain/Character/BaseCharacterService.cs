using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacterService : MonoBehaviour, IBaseCharacterService  {


    public abstract BaseCharacter GetCharacter();
    public abstract BaseRace GetRace();

	// Use this for initialization
	protected void Start () {
        GetCharacter().BasicAttributes = GetRace().GetRacialBasicAttribute(GetCharacter().BasicAttributes);
        GetCharacter().Proficiency = GetRace().GetRacialProficiency(GetCharacter().Proficiency);

    }
	
	// Update is called once per frame
	protected void Update () {
		
	}

    public void ApplyDamage(DomainType domain, float damage) {
        int defense = GetCharacter().Proficiency.GetDomain(domain).Defense.CurrentLevel;

        if (domain != DomainType.THRUST && domain != DomainType.SLASH && domain != DomainType.SMASH)
            defense += GetCharacter().BasicAttributes.Intelligence;
        else
            defense += GetCharacter().BasicAttributes.Constitution;

        if (defense != 0) {
            damage = damage / defense;
        }
        GetCharacter().BasicAttributes.CurrentHP -= damage;
        GetCharacter().Proficiency.GetDomain(domain).Defense.AddExperience((int)damage);
    }
}
