using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDino : MonoBehaviour {

    public float speed = 11.0f;
	    //public Vector2 vecSpeed = new Vector2(-3,0);
	public float jumpSpeed = 8f;

	private bool grounded = true;

    public void Start() {

    }

    public void FixedUpdate() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
             transform.position += Vector3.left * speed * Time.deltaTime;
			 //lastDir = "left";
			 //GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + vecSpeed * Time.deltaTime); //Vector based speed
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
             transform.position += Vector3.right * speed * Time.deltaTime;
			 //lastDir = "right";
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
			if(grounded == true)
			{
				//transform.position += Vector3.up * jumpSpeed * Time.deltaTime; //non-force-based jumping
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpSpeed), ForceMode2D.Impulse);
				grounded = false;
		    }
        }
		 if(Input.GetKeyDown(KeyCode.Escape))
		 {
			 Application.Quit();
		 }
    }

    void OnCollisionEnter2D(Collision2D hit)
	{
    	if (hit.gameObject.tag=="terrain" || hit.gameObject.tag=="platform")
		{
			//Debug.Log("Hit ground");
        	grounded=true;
		}
	}
	void OnCollisionExit2D(Collision2D hit)
	{
		if (hit.gameObject.tag=="terrain" || hit.gameObject.tag=="platform")
		{
			//Debug.Log("Off ground");
			grounded=false;
		}
	}
}