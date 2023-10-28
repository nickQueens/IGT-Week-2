﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float dogDelay = 1.0f;
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (timer <= 0)
        {
            timer = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = dogDelay;
            }
        } else
        {
            timer -= 1 * Time.deltaTime;
        }
        
    }
}
