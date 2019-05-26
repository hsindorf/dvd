using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public float speed = 3.0f;
    public float verticalSpeed = 3.0f;

    void OnCollisionEnter2D(Collision2D col)
    {
    	Vector3 pos = transform.position;
        if(col.gameObject.name == "Left" || col.gameObject.name == "Right")
        {
            speed = -speed;
        }
        if(col.gameObject.name == "Top" || col.gameObject.name == "Bottom")
        {
            verticalSpeed = -verticalSpeed;
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;           
 		pos.x += speed * Time.deltaTime;
        pos.y -= verticalSpeed * Time.deltaTime;
 		transform.position = pos;
 		//Debug.Log(pos);
         
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