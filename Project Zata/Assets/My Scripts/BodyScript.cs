using UnityEngine;
using System.Collections;

public class BodyScript : MonoBehaviour {

	private Vector3 body;

    // Use this for initialization
    void Start () {
	
	}

	void Update() {
	
		body = GameObject.Find("Player").transform.position;

	}

	// Update is called once per frame
	void FixedUpdate () {

		GetComponent<Rigidbody2D>().position = new Vector3 (body.x, body.y, 0);

		//rotation
		Vector3 mousePos = Input.mousePosition;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg -90;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
	}
}
