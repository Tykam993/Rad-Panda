using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
	
	//The current direction of travel
	public Vector2 enemyDir;

	//Enemy's speed
	public float EnemySpeed = -15;

	float castDist = 3f;

	//int layerMask = 1 << 8;
	public BoxCollider2D sideColl;
	public PolygonCollider2D EnemyColl;

	private Vector2 enemyLeft = Vector2.right * -1;

//	rigidbody2D.AddForce (Vector2.right * CharSpeed);
//	transform.up = -rigidbody2D.velocity;

	void Start () {

	}

	void Update () {
		GetComponent<Rigidbody2D>().AddForce(Vector2.right * EnemySpeed);

		if (Physics2D.Raycast(transform.position, -Vector2.up, 3f, 0)) {
			transform.up = -GetComponent<Rigidbody2D>().velocity;
		}

//		RaycastHit2D hitRight = Physics2D.Linecast (transform.position, transform.TransformDirection (Vector2.right), 3f, layerMask); 
//		RaycastHit2D hitLeft = Physics2D.Linecast (transform.position, transform.TransformDirection(-Vector2.right), 3f,layerMask);

//		RaycastHit2D hitRight = Physics2D.Raycast (transform.position, transform.position * 2, 3, 8); 
//		RaycastHit2D hitLeft = Physics2D.Raycast (transform.position, -transform.position * 2, 3, 8);
//			//	rigidbody2D.AddForce (-Vector2.right * EnemySpeed);
//		if (hitRight.distance <= .5) {
//			print ("HELLO THERE");
//			moveLeft = true;
//			moveRight = false;
//		}

		//LeftRay = Physics2D.Raycast (transform.position, transform.TransformDirection(-Vector2.right), 50f,layerMask);
			//rigidbody2D.AddForce (Vector2.right * EnemySpeed);

//		if (hitLeft.distance <= .5) {
//			print ("---------");
//			moveRight = true;
//			moveLeft = false;
//		}
//	}

	}

	void OnTriggerEnter2D(Collider2D coll) {
		EnemySpeed = EnemySpeed * -1;

	}

}