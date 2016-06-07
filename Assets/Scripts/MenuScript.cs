using UnityEngine;
using System.Collections;


public class MenuScript : MonoBehaviour {

	public AudioClip menuTheme;


	//private AudioSource = menuThueme;

	void Start() {
		//menuThemeSource.Play ();


	}

	public void PlayGame() {
		Application.LoadLevel (1);
		}

	public void QuitGame() {
		Application.Quit ();
		}
}
