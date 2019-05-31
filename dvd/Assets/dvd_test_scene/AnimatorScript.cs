using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{

	private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Top")
        {
        	anim.SetBool("isCollideTop", true);
        } else
        {
        	anim.SetBool("isCollideTop", false);
        }

        if(col.gameObject.name == "Bottom")
        {
        	anim.SetBool("isCollideBottom", true);
        } else
        {
        	anim.SetBool("isCollideBottom", false);
        }

        if(col.gameObject.name == "Left")
        {
        	anim.SetBool("isCollideLeft", true);
        } else
        {
        	anim.SetBool("isCollideLeft", false);
        }

        if(col.gameObject.name == "Right")
        {
        	anim.SetBool("isCollideRight", true);
        } else
        {
        	anim.SetBool("isCollideRight", false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
