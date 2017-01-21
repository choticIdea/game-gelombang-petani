using UnityEngine;
using System.Collections;

public class UltraViolet : BaseWave {

	// Use this for initialization
	public float reloadTime = 0.3f;
	public float lifeTime = 0.3f;
	static bool shot = false;

	float t;
	void Start () {
		
			
	}
	void Update(){
		base.Update ();
		if (shot) {
			t -= Time.deltaTime;
			if (t <= 0)
				shot = false;
		}
	}
	protected override void fading ()
	{
		lifeTime -= Time.deltaTime;
		if (lifeTime < 0.7f && lifeTime > 0.1f) {
			Color c = transform.GetChild(0).GetComponent<SpriteRenderer> ().color;
			transform.GetChild(0).GetComponent<SpriteRenderer> ().color = new Color (c.r, c.g, c.b, Mathf.Lerp (c.a, 0, 0.01f));

		} else if (lifeTime < 0.1f)
			Destroy (gameObject);
	}
	public override void spawn (GameObject self, Vector3 pos, Quaternion rot)
	{
		Debug.Log (shot);
		if (shot)
			return;
		else {
			Instantiate (self, pos, rot);
			shot = true;
			t = reloadTime;
		}
	}

}
