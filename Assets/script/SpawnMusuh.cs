using UnityEngine;
using System.Collections;

public class SpawnMusuh : MonoBehaviour {
	public GameObject serangga;
	Vector3 ins;
	float waktu,random;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		waktu += Time.deltaTime;
		if (waktu >= 2) {
			random = Random.value;
			ins = Camera.main.ViewportToWorldPoint (new Vector3 (1, random));
			ins.z = 0;
			Instantiate (serangga, ins, transform.rotation);
			waktu = 0;
		}
	}
}
