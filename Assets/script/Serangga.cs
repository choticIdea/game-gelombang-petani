﻿using UnityEngine;
using System.Collections;

public class Serangga : MonoBehaviour {
	public float kec_serangga_x = 1, kec_serangga_y = 1;
	public int healthPoint;
	float healthPointMultiplier;
	string zigzag = "";
	float waktu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move ();

	}
	protected virtual void  move(){
		
	}

	protected virtual void  specialSkill(){

	}
}
