using UnityEngine;

public class PlayerService : BaseCharacterService, IPlayerService {

    Player Player = new Player();
    
    public override BaseCharacter GetCharacter()
    {
        return Player;
    }

    public override BaseRace GetRace()
    {
        Player.Race = new Human();
        return Player.Race;
    }


    // Use this for initialization
    new void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	new void Update () {
        base.Start();
	}
}
