using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour {

	public float movementSpeed = 50f;
	public float rotationSpeed = 40f;
	public float boostSpeed = 70f;
	private Rigidbody thisRB; 
	private float currentSpeed, accelerationValue = 1, maxSpeed = 10;
	public Text countText; //makes a reference to the score displayed in the UI
	private int count; //stores the number of coins collected
	private Rigidbody rb; //stores a reference to the rigidbody needed to make the collisions work


	void FixedUpdate (){
	
		if (Input.GetKey (KeyCode.A))
			transform.Rotate(Vector3.down * (Time.fixedDeltaTime * rotationSpeed), Space.Self); //lets the player control the yaw left

		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.up * (Time.fixedDeltaTime * rotationSpeed), Space.Self); //lets the player move control the yaw right
		
		if (Input.GetKey (KeyCode.Q))
			transform.Rotate(Vector3.forward * (Time.fixedDeltaTime * rotationSpeed), Space.Self); //lets the player roll left

		if(Input.GetKey(KeyCode.E))
			transform.Rotate(Vector3.back * (Time.fixedDeltaTime * rotationSpeed), Space.Self); //lets the player roll right

		if (Input.GetKey (KeyCode.W))
			transform.Rotate(Vector3.right * (Time.fixedDeltaTime * rotationSpeed), Space.Self); //lets the player pitch down (inverted)

		if(Input.GetKey(KeyCode.S))
			transform.Rotate(Vector3.left * (Time.fixedDeltaTime * rotationSpeed), Space.Self); //lets the player pitch up (inverted)

		if (Input.GetKeyDown (KeyCode.Space))
			movementSpeed = boostSpeed;

		if (Input.GetKeyUp (KeyCode.Space))
			movementSpeed = movementSpeed;
}

	// Use this for initialization
void Start () {
		count = 0; //makes it start at 0
		rb = GetComponent<Rigidbody> (); //allows us to access a rigidbody ref
		SetCountText (); //updates the text with the current value
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime); //this will make the player move forward automatically 1 unit at a time
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Coin")) //checks the collider parameter for a Coin tag
			other.gameObject.SetActive (false); //if the tag is coin, sets the object to inactive.

		count = count +1; //adds 1 to the score when a coin is collected

		SetCountText (); //displays that change in the ui
	}

	void SetCountText ()
	{
		countText.text = "Coins Collected: " + count.ToString (); //makes the text property in the UI "Coins Collected: " plus the number collected
	}

}
