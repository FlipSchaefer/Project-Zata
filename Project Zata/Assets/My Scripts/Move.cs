using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float Speed = 5f;
	private float movex = 0f;
	private float movey = 0f;

	void Update () 
	{
		if (Input.GetKey (KeyCode.A)) {
		movex = -1 + Time.deltaTime;
	} else if (Input.GetKey (KeyCode.D)) {
		movex = 1 + Time.deltaTime;
	} else 
	{
		movex = 0;
	}
	
	if (Input.GetKey (KeyCode.W)) {
		movey = 1 + Time.deltaTime;
		
	} else if (Input.GetKey (KeyCode.S)) {
		movey = -1 + Time.deltaTime;
		
	} else 
	{
		movey = 0;
		
	}
	}

// Update is called once per frame
	void FixedUpdate () 
	{
	GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);
	}
}
