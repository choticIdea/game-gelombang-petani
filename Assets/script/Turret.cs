using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	// Use this for initialization
	Vector3 rot;
	Vector3 mousePos;
	Vector3 pos;
	Vector3 diff;
	BaseWave bulletSpawner;
	public GameObject [] weaponries; 
	public HUD canvas;
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
		canvas.notifyCursor (equipped);
		rot = transform.rotation.eulerAngles;
		rot.z = Mathf.Atan2 (mousePos.y, mousePos.x)* Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(rot);

		if (Input.GetMouseButtonDown (0)) {
			//Bad Spawning
			mousePos.Normalize();
			spawnBullet ();

		}
	}
	void spawnBullet(){
		Vector2 dir = new Vector2 (0,0);
		dir.x = mousePos.x;
		dir.y = mousePos.y;
		BaseWave bw = weaponries [equipped].GetComponent<BaseWave> ();
		switch (bw.type) {
		case "ultraviolet":
			UltraViolet v = (UltraViolet)bw;
			v.spawn (weaponries[equipped], transform.position, transform.rotation);
			break;
		case "ultrasonic" :UltraSonic s = (UltraSonic)bw;
			s.spawn (weaponries[equipped], transform.position, transform.rotation,dir);
			break;
		case "soundwave" :
			SoundWave sw = (SoundWave)bw;
			sw.spawn (weaponries[equipped], transform.position, transform.rotation,dir);
			break;

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
