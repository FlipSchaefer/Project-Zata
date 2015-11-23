using UnityEngine;
using System.Collections;

public class AttackMelee : MonoBehaviour {

    public Transform target;
    public float degree;
    public float speed;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Z: " +target.parent.transform.rotation.z);
        Debug.Log("Z + DEGREE: " + (target.parent.transform.rotation.z + degree));

        target.transform.rotation = Quaternion.Euler(0, 0, target.parent.transform.rotation.z);
        //target.transform.rotation = target.parent.transform.rotation;
        //Debug.Log(target.transform.rotation.z);

        if (Input.GetMouseButtonDown(0))
        {
            
            smoothRotation();

        }
        else
        {

        }


    }

    void smoothRotation()
    {

        target.transform.rotation = Quaternion.Euler(0, 0, (target.parent.transform.rotation.z + degree));
    }
}
