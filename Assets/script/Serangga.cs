using UnityEngine;
using System.Collections;

public class Serangga : MonoBehaviour {
	public float kec_serangga_x = 1, kec_serangga_y = 1;
	string zigzag = "";
	float waktu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		waktu += Time.deltaTime;
		if (waktu >= 1) {
			int randomZigzag = Random.Range (0,2);
			if(randomZigzag == 0)
				zigzag = "naik";
			else if(randomZigzag == 1)
				zigzag = "turun";
			waktu = 0;
		}
		if (zigzag == "naik") {
			if(transform.position.y >= 4)
				transform.Translate (Time.deltaTime * -2 * kec_serangga_x, 0, 0);
			else
				transform.Translate (Time.deltaTime * -2 * kec_serangga_x, Time.deltaTime * 2 * kec_serangga_y, 0);
		} else if (zigzag == "turun") {
			if(transform.position.y <= -4)
				transform.Translate (Time.deltaTime * -2 * kec_serangga_x, 0, 0);
			else
				transform.Translate (Time.deltaTime * -2 * kec_serangga_x, Time.deltaTime * -2 * kec_serangga_y, 0);
		}
	}
}
