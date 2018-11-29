using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFollow : MonoBehaviour {

	public GameObject Player;
	public float movementSpeed = 4;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Player.transform);
		transform.position += transform.forward * movementSpeed * Time.deltaTime;
	}
}
