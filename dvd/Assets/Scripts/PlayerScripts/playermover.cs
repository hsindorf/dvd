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
    public float speed = 1.2f;
    public bool facingRight;
    public bool isJumping = false;
    public int jumpFrames = 0;
    public float jumpRate = 1.5f;
    public int jumpLength = 10;
    

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKey(KeyCode.D)) {

    		Vector3 pos = transform.position;
    		pos.x += speed * Time.deltaTime;
    		transform.position = pos;
    	}

    	if (Input.GetKey(KeyCode.A)) {

    		Vector3 pos = transform.position;
    		pos.x -= speed * Time.deltaTime;
    		transform.position = pos;
    	}

        if (Input.GetKey(KeyCode.Space)) {
            isJumping = true;
            jumpFrames = jumpLength;
        }

        if (isJumping && jumpFrames <= jumpLength){
            Vector3 pos = transform.position;
            pos.y += speed * jumpRate * Time.deltaTime;
            transform.position = pos;
            jumpFrames -= 1;

            if (jumpFrames == 0) {
                isJumping = false;
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