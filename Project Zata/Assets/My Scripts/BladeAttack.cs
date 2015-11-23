using UnityEngine;
using System.Collections;

public class BladeAttack : MonoBehaviour {

    private GameObject body;
    public GameObject standartrotation;
    private Vector3 currentRotation;
    private Vector3 targetRotation;

	// Use this for initialization
	void Start () {

        body = GameObject.FindGameObjectWithTag("Body");
	}
	
	// Update is called once per frame
	void Update () {

        currentRotation = body.transform.eulerAngles;
        Debug.Log(currentRotation.z);


        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Pressed left click.");
            targetRotation.z = currentRotation.z + 180;
            body.transform.eulerAngles = targetRotation;

        }
        
    }
}
