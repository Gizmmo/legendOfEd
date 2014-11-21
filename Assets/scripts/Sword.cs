using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

	public float damage = 1.0f;
	public float swordLifeSpan = 0.5f;
	public float speed = 5.0f;

	private float destroyTime;
	private bool _isShooting = false;

	// Use this for initialization
	void Start () {
		destroyTime = Time.time + swordLifeSpan;
	}
	
	// Update is called once per frame
	void Update () {
		if(isShooting) {
			Vector2 pos = transform.position;
			pos.y += speed * Time.deltaTime;
			transform.position = pos;
		}

		if(Time.time >= destroyTime && !isShooting) {
			DestroySword();
		}
		
	}

	//property for isShooting
	public bool isShooting {
		get {
			return _isShooting;
		}
		set {
			_isShooting = value;
		}
	}

	public void shootSword() {
		if(!_isShooting) {
			_isShooting = true;
			gameObject.transform.parent = null;
		}
	}

	void OnCollisionEnter2D(Collision2D collide) {
		if (collide.gameObject.tag == "Enemy") {
			collide.gameObject.SendMessage("ApplyDamage", damage);	
		}

		if (collide.gameObject.tag != "Player"){
			if (isShooting) {
				Explode();
			}
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
