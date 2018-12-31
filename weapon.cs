using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject blackHolePrefab;

    public Transform firePoint;

    public float timer;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("space")){
            //Debug.Log("autofiring");
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }

        if(Input.GetKey("b")){
            //Debug.Log("black hole gun charging");
            playerMover.rb.velocity = new Vector2(0f, 0f);
            transform.Rotate(0f, 0f, -25f);
            
            timer += Time.deltaTime;
            if(timer > 2){
                //Debug.Log("black hole ready");
                //transform.localScale = (4, 4, 4);
                transform.Rotate(0f, 0f, -30f);
            }
        }
        if(Input.GetButtonUp("BlackHole") && timer > 2){
            //Debug.Log("SUPERMASSIVE BLACK HOLE");
            //instantiate it
            Instantiate(blackHolePrefab, firePoint.position, firePoint.rotation);
            timer = 0f;
        }
	}
}
