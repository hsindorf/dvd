using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public float speed = 1.5f;    


    void OnCollisionEnter2D(Collision2D col)
    {
    	Vector3 pos = transform.position;
        speed = -speed;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;           
 		pos.x += speed * Time.deltaTime;
 		transform.position = pos;
 		//Debug.Log(pos);

         
    }


}


/* 
Here is the stuff you need to move something on the screen in 2d.
- Transform: transform.position = pos;
- Up: pos.y += speed * Time.deltaTime;
- Down: pos.y -= speed * Time.deltaTime;
- Left: pos.x -= speed * Time.deltaTime;
- Right: pos.x += speed * Time.deltaTime;
*/