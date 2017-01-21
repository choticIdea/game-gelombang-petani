using UnityEngine;
using System.Collections;

public class SpawnMusuh : MonoBehaviour {
	public GameObject[] serangga;
	Vector3 ins;
	float waktu,random;
	int wave = 1;
	int waveCountDown = 5;
	int enemiesToDefeat = 10;
	int enemiesToGo = 0;
	int enemyIncrement = 5;
	float incRate = 2f;
	// Use this for initialization
	void Start () {
		Init ();
		prepareWave ();
	}
	void Init(){
		wave = 1;
	}
	void prepareWave(){
		enemyIncrement = Mathf.CeilToInt (enemyIncrement * incRate);
		enemiesToDefeat = enemiesToDefeat + enemyIncrement ;
		enemiesToGo = enemiesToDefeat; 
	}
	// Update is called once per frame
	void Update () {
		waktu += Time.deltaTime;
		if (waktu >= 2) {
			random = Random.value;
			ins = Camera.main.ViewportToWorldPoint (new Vector3 (1, random));
			ins.z = 0;
			ins.x = transform.position.x;
			Instantiate (serangga[Random.Range(0,serangga.Length)], ins, transform.rotation);
			waktu = 0;
		}
	}
}
