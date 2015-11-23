using UnityEngine;
using System.Collections;

public class CollisionBullet : MonoBehaviour {

    public float lifespan;
    public GameObject attacker;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Destroy(gameObject, lifespan);

	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
        Debug.Log("collision tag = " + col.gameObject.tag);

        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);

        }
        
        if (col.gameObject.tag != attacker.tag)
        {
            Destroy(gameObject);
        }

    }

}
