using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerPosition;
        
    private Camera mainCamera;

    [SerializeField]
    private float minX, maxX;

    [SerializeField]
    private float minY, maxY;

    private Vector3 tempPos;

    private void Awake()
    {
        playerPosition = GameObject.FindWithTag("Player").GetComponent<Transform>();
        mainCamera = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y, mainCamera.transform.position.z);

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
}
