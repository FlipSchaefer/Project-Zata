using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

    public GameObject Bullet;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletInstance = Instantiate(Bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            bulletInstance.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);

        }


    }

}
