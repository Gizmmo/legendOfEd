using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public int speed = 5;
	private int maxMoves = 120;
	public int movePerSecond = 1;
	public int bodySpace = 10;
	public float Step = 20.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Random.Range (0, maxMoves + 1) > maxMoves - movePerSecond){
			moveRandom ();
		}
	}

	void moveRandom () {
		bool moveX = Random.Range (0, 2) == 0 ? true: false;
		int randomX = 0;
		int randomY = 0;
		if (moveX){
			randomX = Random.Range(-1, 2);
		}else{
			randomY = Random.Range(-1, 2);
		}

		Vector2 movement = new Vector2(speed * randomX * bodySpace, speed * randomY * bodySpace);
		transform.position = Vector2.MoveTowards(transform.position, movement, Step);
	}
}
