using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame() {

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); 

	}

	public void QuitGame() {
		//Doesn't even work in webgl builds smh, quit button will direct to credits screen instead
		Debug.Log ("quit working");
		Application.Quit ();

	}

	public void Replay(){

		SceneManager.LoadScene ("Menu"); 
	}

	public void Credits(){

		SceneManager.LoadScene ("Credits");

	}

	public void Tutorial(){

		SceneManager.LoadScene ("Tutorial");

	}
}