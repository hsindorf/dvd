using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass_move_anim : MonoBehaviour
{
    // Start is called before the first frame update
	Animator m_Animator;
    // Use this for deciding if the GameObject can jump or not
    void Start()
    {
        //This gets the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void OnCollisionEnter2(Collision collision)
	    {
	        //Check for a match with the specified name on any GameObject that collides with your GameObject
	        if (collision.gameObject.name == "Mushroom")
	        {
	            m_Animator.SetBool("touchingPlayer", true);
	        }
	        else {
	        	m_Animator.SetBool("touchingPlayer", false);
	        }

	    }

    void Update()
    {
      void OnCollisionEnter(Collision collision)
	    {
	        //Check for a match with the specified name on any GameObject that collides with your GameObject
	        if (collision.gameObject.name == "Mushroom")
	        {
	            m_Animator.SetBool("touchingPlayer", true);
	        }
	        else {
	        	m_Animator.SetBool("touchingPlayer", false);
	        }

	    }


	    if (Input.GetKey(KeyCode.S)) {
	    	m_Animator.SetBool("touchingPlayer", true);
	    }

    }





}
