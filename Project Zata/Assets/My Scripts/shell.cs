using UnityEngine;
using System.Collections;

public class shell : MonoBehaviour {

	public GameObject hulse;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        GameObject myObj = Instantiate(hulse) as GameObject;

        myObj.transform.position = GameObject.Find("shell_output").transform.position;

    }
}
