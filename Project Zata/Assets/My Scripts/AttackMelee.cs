using UnityEngine;
using System.Collections;

public class AttackMelee : MonoBehaviour {

    public Transform target;        //is the Object where the melee weapon is attached to. normal is some kind of body
    public float degree;            //degree
    public float speed;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {


        target.transform.rotation = target.parent.transform.rotation;
        Debug.Log("normal: " + target.transform.rotation);

        if (Input.GetMouseButtonDown(0))
        {

            //smoothRotation(angle);
            Debug.Log("click: " + target.transform.rotation);
            target.transform.rotation = Quaternion.Slerp(target.transform.rotation, Quaternion.AngleAxis(degree, Vector3.back), speed * Time.deltaTime);
        }
        else
        {
            //target.transform.rotation = Quaternion.Lerp(Quaternion.AngleAxis(angle + degree, Vector3.back), Quaternion.AngleAxis(angle, Vector3.back), speed * Time.deltaTime);
        }


    }

    void smoothRotation(float angle)
    {

        //the target gets a slerp rotation so the melee weapon rotates smooth
        //Quaternion A = is the actual rotation on Z
        //Quaternion B = A + the degree to rotate over Z
        //T = speed = time to go from A to B in 0 to 1
        //BUGGIE cause slerp doesnt work as it should =P
        target.transform.rotation = Quaternion.Lerp(Quaternion.AngleAxis(angle, Vector3.forward), Quaternion.AngleAxis(angle + degree, Vector3.forward), speed * 2.0f);
    }
}
