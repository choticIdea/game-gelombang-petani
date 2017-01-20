using UnityEngine;
using System.Collections;

public class Serangga : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Time.deltaTime * -2, 0,0);
	}
}
