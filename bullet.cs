using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public Rigidbody2D rb;
    public int bulletSpeed;
    public GameObject go;

	// Use this for initialization
	void Start () {
        transform.Rotate(0f, 0f, 270f);
        //rb.velocity = new Vector2(bulletSpeed,rb.velocity.y);
        // Something like transform.right to make it shoot left when facing left
        rb.velocity = transform.up * bulletSpeed;

	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x > 240 || transform.position.x <-100){
            Destroy(go);
        }
	}

    void OnCollisionEnter2D(Collision2D target)
    {
        mover mover = target.gameObject.GetComponent<mover>();
        if(mover != null){
            mover.TakeDamage(1);
            //Debug.Log("dealing damage");
        }
        //Debug.Log("I hit something"); // for some reason this isn't working so I'll make the bullets not triggers
        //Debug.Log(target.gameObject.name);
        if(target.gameObject.tag == "star"){
            //Debug.Log("hit a star!");


            // deal damage to star
        }
    }
}
