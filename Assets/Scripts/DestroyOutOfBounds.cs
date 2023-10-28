using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 40;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    // If object leaves camera view, destroy
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            // If animal passes player and leaves camera, then game over
            gameManager.AddLives(-1);
        }
        else if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
            // If animal passes player and leaves camera, then game over
            gameManager.AddLives(-1);
        }
        else if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
            // If animal passes player and leaves camera, then game over
            gameManager.AddLives(-1);
        }
    }
}
