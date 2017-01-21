using UnityEngine;
using System.Collections;

public class BaseWave : MonoBehaviour {

	// Use this for initialization
	protected Vector2 dir;
	public float baseSpeed = 10f;
	protected int baseDamage;
	public string type = "Base";
	protected int level;
	protected float damageMultiplier;
	protected float normal = 1;
	protected float uneffective = 0.5f;
	protected float effective = 1.5f;
    protected virtual void Start () {
		Debug.Log ("parent init !");
	}
	
	// Update is called once per frame
	 protected virtual void Update () {
		//spawn ();
		move ();
		fading ();
	
	}
	public void setSpeedDir(Vector2 speeddir){
		dir = speeddir;
		Debug.Log ("Speed set !");
	}
	void checkOutofBoundaries(){
	
	}
	public virtual void spawn (GameObject self,Vector3 pos,Quaternion rot){
		Instantiate (self, pos, rot);
	}

	protected virtual void move(){
	}
	protected virtual void fading(){
	}
	//TODO : Collider with enemies
}
