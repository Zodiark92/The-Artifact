using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed=3f;

    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;

    private Vector3 moveVector;

    private float harvestTimer;
    private bool isHarvesting;

    private GameObject artifact;

    [HideInInspector]
    public bool gameOver;

    private string Movement_X = "Horizontal";
    private string Movement_Y = "Vertical";


    [SerializeField]
    private float minX,maxX;

    [SerializeField]
    private float minY, maxY;

    private Vector3 tempPos;


    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        FlipSprite();

        if (Time.time > harvestTimer)
            isHarvesting = false;


        tempPos = transform.position;

        if (tempPos.x < minX)
            tempPos.x = minX;

        if (tempPos.x > maxX)
            tempPos.x = maxX;

        if (tempPos.y < minY)
            tempPos.y = minY;

        if (tempPos.y > maxY)
            tempPos.y = maxY;

        transform.position = tempPos;

    }
    private void FixedUpdate()
    {
        if (isHarvesting || gameOver) 
        {

            myBody.velocity = Vector2.zero;

        }
        else
        {

            moveVector = new Vector2(Input.GetAxis(Movement_X), Input.GetAxis(Movement_Y));

            if (moveVector.sqrMagnitude > 1)
                moveVector = moveVector.normalized;
               
            
          

            myBody.velocity = new Vector2(moveVector.x * movementSpeed, moveVector.y * movementSpeed);
           
           

        }
    }

    private void FlipSprite()
    {
        if (!gameOver)
        {

            if (Input.GetAxisRaw(Movement_X) == 1)
            {

                sr.flipX = false;
            }
            else if (Input.GetAxisRaw(Movement_X) == -1)
            {

                sr.flipX = true;
            }
        }
    }


    public void HarvestStopMovement(float time)
    {
        isHarvesting = true;
        harvestTimer = Time.time + time;


    }

    public bool IsHarvesting()
    {

        return isHarvesting;
    }

}
