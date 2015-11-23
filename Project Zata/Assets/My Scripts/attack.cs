using UnityEngine;
using System.Collections;

public class attack : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();


	}
	
	// Update is called once per frame
	void Update () {

		

		if (Input.GetMouseButtonDown (0)) {

			Debug.Log("Pressed left click.");
			anim.SetBool ("Shoot", true);

        } 
		else 
		{
			anim.SetBool ("Shoot", false);
		}

	}
}
