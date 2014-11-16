using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	
	public float timeBetweenAttacks = 0.5f;
	public GameObject sword;
	public float swordYPosition;
	public float swordXPosition;

	private GameObject visibleSword;
	private float timestamp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= timestamp)
		{
			Destroy (visibleSword);

			if (Input.GetKeyDown(KeyCode.Space)) {
				Vector3 pos = transform.position;
				pos.x += swordXPosition;
				pos.y += swordYPosition;
				visibleSword = Instantiate(sword, pos, transform.rotation) as GameObject;
				timestamp = Time.time + timeBetweenAttacks;
			}
		}
	}
}
