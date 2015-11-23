using UnityEngine;
using System.Collections;

public class RotatePlayer : MonoBehaviour {

    public float delay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePos = Input.mousePosition;                                             //get mouse position                                     
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);             //Get object position and put it "on the screen" (same as mouse)                
        Vector3 offset = new Vector3(mousePos.x - screenPos.x, mousePos.y - screenPos.y);   //Check where the mouse is relative to the object 

        float angle = Mathf.Atan2(offset.x, offset.y) * Mathf.Rad2Deg;                      //Turn that into an angle and convert to degrees
        float delayAngle = Mathf.Atan2(offset.x - delay, offset.y - delay) * Mathf.Rad2Deg;

        Debug.Log("angle: " + angle);
        Debug.Log("angle: " + angle + " " +"delayangle: " + delayAngle + " " + "mauspos: " + mousePos);

        if (mousePos.x > 0)
            delayAngle = 360 - delayAngle;

        transform.rotation = Quaternion.Euler(0, 0, delayAngle);

    }
}
