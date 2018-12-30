using UnityEngine;

public class PlayerService : BaseCharacterService, IPlayerService {

    Player Player = new Player();
    
    public override BaseCharacter GetCharacter()
    {
        return Player;
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
