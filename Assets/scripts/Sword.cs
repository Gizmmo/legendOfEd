using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

	public float damage = 1.0f;
	public float swordLifeSpan = 0.5f;

	private float destroyTime;
	private bool _isShooting = false;

	// Use this for initialization
	void Start () {
		isShooting = false;
		destroyTime = Time.time + swordLifeSpan;
	}
	
	// Update is called once per frame
	void Update () {
		if(isShooting) {
			print ("Sword HO!!!");
		}

		if(Time.time >= destroyTime && !isShooting) {
			DestroySword();
		}
		
	}

	public bool isShooting {
		get {
			return _isShooting;
		}
		set {
			_isShooting = value;
		}
	}

	void OnCollisionEnter2D(Collision2D collide) {
		if (collide.gameObject.tag == "Enemy") {
			collide.gameObject.SendMessage("ApplyDamage", damage);	
		}

		if(isShooting) {
			Explode();
		}
	}

	void Explode() {
		//Enter effects in here later!
		DestroySword();
	}

	void DestroySword() {
		Destroy(gameObject);
	}

}
