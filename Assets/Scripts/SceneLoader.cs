using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// this allows the player to reload the game in the win screen
	public void LoadScene() 
	{
		SceneManager.LoadScene ("dragon chase");
	}

}
