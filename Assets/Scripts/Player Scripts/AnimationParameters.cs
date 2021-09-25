using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationParameters : MonoBehaviour
{
    private Rigidbody2D mybody;
    private Animator anim;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animate();
        
    }

    void Animate()
    {
        if(mybody.velocity == Vector2.zero)
        {
            anim.SetBool("walk", false);

        }
        else
        {
            anim.SetBool("walk", true);
        }

    }




}
