using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
			if(other.tag == "Player")
			{
				SceneManager.LoadScene("Dragon Chase"); //restarts the level if the player is touched by the dragon
			}
		
	}
}
