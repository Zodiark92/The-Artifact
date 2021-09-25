using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Sprite[] animSprites;

    public float timeThreshold = 0.01f;
    private float timer;

    private int state = 0;
    private SpriteRenderer sr;

    private PlayerMovement playerMovement;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        

        if (Time.time > timer)
        {
            if (!playerMovement.gameOver)
            {
                sr.sprite = animSprites[state % animSprites.Length];

                state++;

                timer = Time.time + timeThreshold;

            }

        }
    }




}
