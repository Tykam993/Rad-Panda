using UnityEngine;
using System.Collections;



public class GroundScript : MonoBehaviour {
	
	public bool Ground;
	public bool Lava;
	public bool Ice;
	public bool Molasses;

	public float stateDuration = 5f;
	public int lavaDmgEn = 1000;
	public int lavaDmgPl = 1;
	
	private float normFriction = 0.4f;
	public float iceFriction = 0.0f;

	[HideInInspector]
	public GameObject[] enemies;

	[HideInInspector]
	public GameObject player;
	
	[HideInInspector]
	public float timeOfChange;

	void Start () {
		Ground = true;
		timeOfChange = Time.time;
	}

	void OnCollisionStay2D(Collision2D col) {
		if (Lava) {
			if (col.gameObject.tag == "Enemy") {
				Health enemyHealth = col.gameObject.GetComponent<Health>();
				enemyHealth.HP -= lavaDmgEn;
			}
			if (col.gameObject.tag == "Player") {
				Health playerHealth = col.gameObject.GetComponent<Health>();
				playerHealth.HP -= lavaDmgPl;
			}
		}
	}

	void Update () {
		if (Ice) {
			// Grab all enemies and the player
			enemies = GameObject.FindGameObjectsWithTag("Enemy");
			player = GameObject.FindGameObjectWithTag("Player");

			foreach (GameObject e in enemies) {

			}

			Collider2D c = gameObject.GetComponent<Collider2D>();
			c.sharedMaterial.friction = iceFriction;
		}
		else if (Molasses) {
			// Grab all enemies and the player
			player = GameObject.FindGameObjectWithTag("Player");
		}
		else { // Ground
			// Grab all enemies and the player
			player = GameObject.FindGameObjectWithTag("Player");

		}
	}

	void FixedUpdate() {
		if (Time.time - timeOfChange >= stateDuration) {
			Ground		= true;
			Lava		= false;
			Ice			= false;
			Molasses	= false;
			
			Collider2D c = gameObject.GetComponent<Collider2D>();
			c.sharedMaterial.friction = normFriction;
		}
	}
}
