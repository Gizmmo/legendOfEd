using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float currentHealth = 3;
	public float fullHealth = 3;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool isFullHealth() {
		if (currentHealth == fullHealth) {
			return true;
		}

		return false;
	}
}
