using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAnim : MonoBehaviour
{
    [SerializeField]
    private Sprite[] wolfAnimSprites;

    [SerializeField]
    private float animTimeThreshold = 0.15f;

     private WolfAI wolfAI;

    private SpriteRenderer sr;

    private int state = 0;
    private float animTimer;

    private GameObject artifact;

    private void Awake()
    {
         sr = GetComponent<SpriteRenderer>();
         wolfAI=GetComponent<WolfAI>();

        artifact = GameObject.FindWithTag("Artifact");
    }

    private void Update()
    {
        if (!artifact)
            wolfAI.isMoving = false;



        if (wolfAI.isMoving)
        {

            if (Time.time > animTimer)
            {
                sr.sprite = wolfAnimSprites[state % wolfAnimSprites.Length];
                state++;

                animTimer = Time.time + animTimeThreshold;


            }

        }

          else
                sr.sprite=wolfAnimSprites[0];


                sr.flipX=wolfAI.left;  

    }



}
