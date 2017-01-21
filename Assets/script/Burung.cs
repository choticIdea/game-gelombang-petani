using UnityEngine;
using System.Collections;

public class Burung : Serangga {

	// Use this for initialization
	string zigzag = "";
	float waktu;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	protected override void move(){
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
