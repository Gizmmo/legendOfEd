using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	
	public float timeBetweenAttacks = 1.0f;
	public float timeSwordIsOut = 0.5f;
	public GameObject sword;
	public float swordYPosition;
	public float swordXPosition;

	private GameObject shootingSword;
	private GameObject visibleSword;
	private float timestamp;
	private Player playerScript;

	// Use this for initialization
	void Start () {
		playerScript = gameObject.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timestamp && Input.GetKeyDown(KeyCode.Space)) {
			Vector3 pos = transform.position;
			pos.x += swordXPosition;
			pos.y += swordYPosition;
			visibleSword = Instantiate(sword, pos, transform.rotation) as GameObject;
			if(playerScript.isFullHealth() && shootingSword == null) {
				shootingSword = visibleSword;
				shootingSword.GetComponent<Sword>().shootSword();
			} else {
				visibleSword.transform.parent = gameObject.transform;
			}
			timestamp = Time.time + timeBetweenAttacks;
		}
	}
}
