using UnityEngine;
using System.Collections;

public class UltraSonic : BaseWave {

	// Use this for initialization
	public float lifeTime = 0.4f;
	void Start () {
		

		Debug.Log (type);
	}
	protected override void move(){
		Vector2 pos = transform.position;
		pos += dir*baseSpeed*Time.deltaTime;
		transform.position = pos;
	}
	// Update is called once per frame

	public void spawn (GameObject self, Vector3 pos, Quaternion rot,Vector2 dir)
	{
		GameObject spawned = (GameObject) Instantiate (self, pos, rot);
		UltraSonic sw = spawned.GetComponent<UltraSonic> ();
		sw.setSpeedDir (dir);

	}
	protected override void fading ()
	{
		lifeTime -= Time.deltaTime;
		Vector3 scale = transform.localScale;
		scale.x += 2 * Time.deltaTime;
		scale.y += 2 * Time.deltaTime;
		transform.localScale = scale;
		if (lifeTime < 0.7f && lifeTime > 0.1f) {
			Color c = GetComponent<SpriteRenderer> ().color;
			GetComponent<SpriteRenderer> ().color = new Color (c.r, c.g, c.b, Mathf.Lerp (c.a, 0, 0.01f));
			Debug.Log (GetComponent<SpriteRenderer> ().color.a);
		} else if (lifeTime < 0.1f)
			Destroy (gameObject);
	}
}
