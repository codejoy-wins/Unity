using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {


    public Rigidbody2D rb;
    public int speed;
    public bool movingRight;
    public bool movingUp;
    public int left;
    public int right;
    public int up;
    public int down;

    public static int xp = 18;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        movingRight = true;
        movingUp = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (movingRight == true){
            rb.velocity = new Vector2(5, rb.velocity.y);
        }else if(movingRight == false){
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        if(movingUp == true){
            rb.velocity = new Vector3(rb.velocity.x, .6f);
        }else if(movingUp == false){
            rb.velocity = new Vector2(rb.velocity.x, -1f);
        }


        if (transform.position.x < left){
            movingRight = true;
        }
        if (transform.position.x > right){
            movingRight = false;
        }
        if (transform.position.y < down)
        {
            movingUp = true;
        }
        else if (transform.position.y > up)
        {
            movingUp = false;
        }
    }

}
