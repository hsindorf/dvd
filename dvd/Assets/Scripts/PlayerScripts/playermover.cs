using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Public Variables
    public float speed = 1.6f;
    public bool facingRight;
    public bool isJumping = false;
    public int jumpFrames = 0;
    public float jumpRate = 2.7f;
    public int jumpLength = 10;
    public float horizontalBoost = 1.8f; // My jumping code (can be fixed later) deals with the speed
    // variable, so do make the player go faster horizontally I added a boost. Could also be used for collectables
    

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKey(KeyCode.D)) {                  // Left

    		Vector3 pos = transform.position;
    		pos.x += horizontalBoost * speed * Time.deltaTime;
    		transform.position = pos;
    	}

    	if (Input.GetKey(KeyCode.A)) {                  // Right

    		Vector3 pos = transform.position;
    		pos.x -= horizontalBoost * speed * Time.deltaTime;
    		transform.position = pos;
    	}

    	if (isJumping != true) {                        // Are you currently jumping?

	    	if (Input.GetKey(KeyCode.Space)) {          // If you are jumping, set the number of jump frames equal
	            isJumping = true;                       // to the length of the player's current jump
	            jumpFrames = jumpLength;
	        }
    	}


        if (isJumping && jumpFrames <= jumpLength){     // Jump Logic that states if the player isjumping is true, and
            Vector3 pos = transform.position;           // the number of frames left in the jump is less than the player
            pos.y += speed * jumpRate * Time.deltaTime; // default jump length, then move up and subtract a jump frame
            transform.position = pos;
            jumpFrames -= 1;

            if (jumpFrames == 0) {                      // If the number of jump frames left is zero, set isJumping
                isJumping = false;                      // to false
            }
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


