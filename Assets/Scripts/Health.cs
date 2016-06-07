using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public AudioSource EnemyDieAudio;
	public AudioSource PlayerDieAudio;

	public int HP;

	public GameObject[] ThePlayer;
	public GameObject[] Enemies;
	
	// Use this for initialization
	void Start () {
		HP = 500;
	}

	void Update() {
		ThePlayer = GameObject.FindGameObjectsWithTag("Player");
		Enemies = GameObject.FindGameObjectsWithTag("Enemy");

		if (HP <= 0) {
			GameObject.Destroy(gameObject);

			foreach (GameObject enemy in Enemies) {
			
				EnemyDieAudio.Play ();
			}


			foreach (GameObject player in ThePlayer) {
			
				PlayerDieAudio.Play ();

			}
		}
	}
}
