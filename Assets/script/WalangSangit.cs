using UnityEngine;
using System.Collections;

public class WalangSangit  : Serangga {

	// Use this for initialization
	Vector2 moveDir;
	const float coolDown = 2f;
	float burstCooldown =0;
	int burst = -1;
	const int burstStraight = 0;
	const int burstDown = 1;
	const int burstUp = 2;
	float burstTime = 3f;
	int maxBurstSpeed = 4;
	int minBurstSpeed = 2;
	int burstMultiplier= 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		burstCooldown -= Time.deltaTime;
		if (burstCooldown <= 0)
			burst = Random.Range (0, 3);
		else if (burst != -1) {
			burstTime -= Time.deltaTime;
			if (burstTime <= 0) {
				burst = -1;
				burstCooldown = coolDown;
			}
		}
		move ();
	}
	protected override void move ()
	{
		moveDir = new Vector2 (kec_serangga_x, kec_serangga_y);
		if (burst != -1) {
			
			burstMultiplier = Random.Range (minBurstSpeed, maxBurstSpeed);
			switch (burst) {
			case burstStraight: 
				moveDir = moveDir * burstMultiplier;
				moveDir.y = 0;
				break;
			case burstUp: 
				
				moveDir.y = 0.4f;
				moveDir = moveDir * burstMultiplier;
				moveDir.x = 0.05f * moveDir.x;
				break;
			case burstDown:
				moveDir.y = -0.4f;
				moveDir = moveDir * burstMultiplier;
				moveDir.x = 0.05f * moveDir.x;
				break;
			}

		}
		Debug.Log (moveDir);
		transform.Translate (moveDir*Time.deltaTime*5f);
	}
}
