using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartGame(){
		SceneManager.LoadScene ("game");
	}
	public void Tutorial(){
		SceneManager.LoadScene ("Tutorial");
	}
	public void Credits(){
		SceneManager.LoadScene ("Credits");
	}
	public void Exit(){
		Application.Quit ();
	}
}
