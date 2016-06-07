using UnityEngine;
using System.Collections;

public class changeTag : MonoBehaviour {

	//public AudioClip PlayerLava;
	public AudioClip PlayerIce;
	public AudioClip PlayerMolasses;
	
	public GameObject[] groundObs;		// Array of all Ground objects

	void Start() {
		//Create Array of all Ground Objects
		groundObs = GameObject.FindGameObjectsWithTag("Ground");



	}

	void Update () {
		//Lava input
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			print ("LAVA");
			//Set each Lava bool to true
			foreach (GameObject ground in groundObs) {

				//Get Component
				GroundScript localGroundControl = ground.GetComponent<GroundScript>();
				localGroundControl.Lava = true;
				localGroundControl.Ground = false;
				localGroundControl.Ice = false;
				localGroundControl.Molasses = false;

				//PlayerLava.Play ();

				// Set the timer to the current time
				localGroundControl.timeOfChange = Time.time;
			}
		}

		//Ice input
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			print ("ICE");
			//Set each Ice bool to true
			foreach (GameObject ground in groundObs) {
				
				//Get Component
				GroundScript localGroundControl = ground.GetComponent<GroundScript>();
				localGroundControl.Lava = false;
				localGroundControl.Ground = false;
				localGroundControl.Ice = true;
				localGroundControl.Molasses = false;

				GetComponent<AudioSource>().PlayOneShot (PlayerIce);
				
				// Set the timer to the current time
				localGroundControl.timeOfChange = Time.time;
			}
		}

		//Molasses input
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			print ("MOLASSES");
			//Set each Molasses bool to true
			foreach (GameObject ground in groundObs) {
				
				//Get Component
				GroundScript localGroundControl = ground.GetComponent<GroundScript>();
				localGroundControl.Lava = false;
				localGroundControl.Ground = false;
				localGroundControl.Ice = false;
				localGroundControl.Molasses = true;

				GetComponent<AudioSource>().PlayOneShot (PlayerMolasses);
				
				// Set the timer to the current time
				localGroundControl.timeOfChange = Time.time;
			}
		}
	}
}
	