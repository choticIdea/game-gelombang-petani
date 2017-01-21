using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	// Use this for initialization
	public static int playerCoins;
	public static int playerScore;
	public static int paddyHealth;
	public static bool gameOver = false;

	public void Init () {
		playerCoins = 0;
		playerScore = 0;
		paddyHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void DetermineEnemySets(){
	
	}
	void SaveGame(){
	//stubs
	}
	void LoadGame(){
	//stubs
	}

}
