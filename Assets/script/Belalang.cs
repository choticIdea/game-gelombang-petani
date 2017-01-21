using UnityEngine;
using System.Collections;

public class Belalang  : Serangga {

	// Use this for initialization
	public GameObject ground;
	const int grounded = 0;
	const int flying = 1;
	int state;
	const float jumpPower = 2f;
	float jumpForce = 2f;
	float jumpCooldown = 3f;
	float jumpSpeed = 3f;
	Vector2 moveDir;
	void Start () {
		state = grounded;
	}
	
	// Update is called once per frame
	void Update () {
		if (state == grounded && transform.position.y > ground.transform.position.y) {
			fallDown ();
		} else if (state == grounded) {
			move ();
		} else if (state == flying) {
			jumping ();
		}
	}
	void jumping(){
		moveDir =new Vector2 (kec_serangga_x * jumpSpeed,jumpForce);
		jumpForce -= 0.2f;
		transform.Translate(moveDir*Time.deltaTime);
		if(transform.position.y <= ground.transform.position.y){
			state = grounded;
			jumpForce = jumpPower;
		}
	}
	void fallDown(){
		moveDir = new Vector2 (kec_serangga_x*0.5f,kec_serangga_y*-2f);
		transform.Translate (moveDir* Time.deltaTime);
		if (transform.position.y <= ground.transform.position.y) {
			moveDir = transform.position;
			moveDir.y = ground.transform.position.y;
			state = grounded;
		}
	}
	protected override void move ()
	{
		moveDir = new Vector2 (kec_serangga_x, 0);
		transform.Translate (moveDir * Time.deltaTime);
		jumpCooldown -= Time.deltaTime;
		if (jumpCooldown <= 0) {
			jumpCooldown = Random.Range (0, 1.5f);
			state = flying;
		}
	}

}
