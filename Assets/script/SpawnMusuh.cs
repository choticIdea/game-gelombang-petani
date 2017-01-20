using UnityEngine;
using System.Collections;

public class SpawnMusuh : MonoBehaviour {
	public GameObject serangga;

	float waktu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		waktu += Time.deltaTime;
		if (waktu >= 1) {
			Instantiate (serangga, transform.position, transform.rotation);
			waktu = 0;
		}
	}
}
