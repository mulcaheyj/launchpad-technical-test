using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFollow : MonoBehaviour {

	public GameObject Player; //sets which gameobject to look at
	public float movementSpeed = 4; //allows movement speed to be customised in editor

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Player.transform); //makes the dragon look at the player
		transform.position += transform.forward * movementSpeed * Time.deltaTime; //makes the dragon constantly move towards the player
	}
}
