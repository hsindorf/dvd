using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Flip(){
	    // Switch the way the player is labelled as facing
	    // Multiply the player's x local scale by -1
	    Vector3 theScale = transform.localScale;
	    theScale.x *= -1;
	    transform.localScale = theScale;
	}

    // Public Variables
    public float speed = 1.2f;
    public bool facingRight;

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKey(KeyCode.D)) {
    		Flip();
    		facingRight = true;

    		Vector3 pos = transform.position;
    		pos.x += speed * Time.deltaTime;
    		transform.position = pos;
    	}




    	if (Input.GetKey(KeyCode.A)) {
    		Flip();
    		facingRight = false;

    		Vector3 pos = transform.position;
    		pos.x -= speed * Time.deltaTime;
    		transform.position = pos;
    	}
        
    }
}


/* 
Here is the stuff you need to move something on the screen in 2d.
- Initiate: Vector3 pos = transform.position;
- Transform: transform.position = pos;
- Up: pos.y += speed * Time.deltaTime;
- Down: pos.y -= speed * Time.deltaTime;
- Left: pos.x -= speed * Time.deltaTime;
- Right: pos.x += speed * Time.deltaTime;
*/