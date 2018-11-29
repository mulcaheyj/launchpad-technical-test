using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {

	void OnTriggerEnter (Collider other) //same as when the dragon gets the player - when the player enters this collider it ends the game
	{
		if(other.tag == "Player")
		{
			SceneManager.LoadScene("You Escaped!"); //takes the player to the win screen to retry
		}

	}
}
