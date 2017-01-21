using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	// Use this for initialization
	public GameObject weaponCursor;
	public GameObject[] weaponIcons;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void notifyCursor(int cursor){
		weaponCursor.transform.position = weaponIcons [cursor].transform.position;
	}
}
