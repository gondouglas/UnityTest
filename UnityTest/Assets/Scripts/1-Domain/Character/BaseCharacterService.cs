using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacterService : MonoBehaviour, IBaseCharacterService  {


    public abstract BaseCharacter GetCharacter();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
