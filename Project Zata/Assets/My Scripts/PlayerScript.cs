using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	private Animator anim;
	//private Vector3 body;

	private Transform walkway;

	//public float Speed = 5f;
	//private float movex = 0f;
	//private float movey = 0f;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate () 
	{
		//body = GameObject.Find("Player").transform.position;

		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.W)) {
		
			transform.rotation = Quaternion.Euler(0,0,45);
			anim.SetBool ("walkTrue", true);

		
		} else if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S)) {
		
			transform.rotation = Quaternion.Euler(0,0,135);
			anim.SetBool ("walkTrue", true);

		
		} else if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.W)) {
		
			transform.rotation = Quaternion.Euler(0,0,315);
			anim.SetBool ("walkTrue", true);


		} else if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.S)) {

			transform.rotation = Quaternion.Euler(0,0,225);
			anim.SetBool ("walkTrue", true);

		
		}else if (Input.GetKey (KeyCode.A)) {

			transform.rotation = Quaternion.Euler(0,0,90);
			anim.SetBool ("walkTrue", true);
			
		} else if (Input.GetKey (KeyCode.D)) {

			transform.rotation = Quaternion.Euler(0,0,270);
			anim.SetBool ("walkTrue", true);
			
		} else if (Input.GetKey (KeyCode.W)) {

			transform.rotation = Quaternion.Euler(0,0,0);
			anim.SetBool ("walkTrue", true);
			
		} else if (Input.GetKey (KeyCode.S)) {

			transform.rotation = Quaternion.Euler(0,0,180);
			anim.SetBool ("walkTrue", true);
			
		} else {
			
			anim.SetBool ("walkTrue", false);
			
		}

		//GetComponent<Rigidbody2D>().position = new Vector3 (body.x, body.y, 0);
	}
	
}
