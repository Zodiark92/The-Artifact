using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    private static Audio audioInstance;

    private void Awake()
    {
        if (!audioInstance)
        {

            audioInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);


    }



}
