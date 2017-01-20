using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	// Use this for initialization
	Vector3 rot;
	Vector3 mousePos;
	Vector3 pos;
	Vector3 diff;
	public GameObject [] weaponries; 
	int equipped = 0; // 0,1,2
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		equipped = equipped + checkMouseScrolls ();
		if (equipped > weaponries.Length - 1)
			equipped = 0;
		else if (equipped < 0)
			equipped = weaponries.Length - 1;
		
		rot = transform.rotation.eulerAngles;
		rot.z = Mathf.Atan2 (mousePos.y, mousePos.x)* Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(rot);

		if (Input.GetMouseButtonDown (0)) {
			//Bad Spawning
			mousePos.Normalize();
			GameObject g = (GameObject) Instantiate (weaponries[equipped], transform.position, transform.rotation);
			Wave w = g.GetComponent<Wave> ();
			Vector2 dir = new Vector2 (0,0);
			dir.x = mousePos.x;
			dir.y = mousePos.y;
			w.setSpeedDir (dir);
		}
	}
	int checkMouseScrolls(){
		if (Input.mouseScrollDelta.y > 0)
			return 1;
		else if (Input.mouseScrollDelta.y < 0)
			return -1;
		else
			return 0;
	}
}
