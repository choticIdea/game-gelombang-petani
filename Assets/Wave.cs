using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour {

	// Use this for initialization
	Vector2 dir;
	public float baseSpeed = 2f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = transform.position;
		pos += dir*baseSpeed;
		transform.position = pos;
	}
	public void setSpeedDir(Vector2 speeddir){
		dir = speeddir;
		Debug.Log ("Speed set !");
	}
	void checkOutofBoundaries(){
	
	}
}
