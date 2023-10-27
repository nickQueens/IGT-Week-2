using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawnMinZ = 5;
    private float spawnMaxZ = 15;
    private float spawnPosZ = 20;
    private float spawnPosX = 30;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Call SpawnRandomAnimal() at regular intervals
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn random animal
    void SpawnRandomAnimal()
    {
        int spawnType = Random.Range(0, 3);
        Vector3 position;
        Vector3 rotation = new Vector3(0, 180, 0);
        switch (spawnType)
        {
            // Left
            case 0:
                position = new Vector3(-spawnPosX, 0, Random.Range(spawnMinZ, spawnMaxZ));
                rotation = new Vector3(0, 90, 0);
                break;
            // Top
            case 1:
                position = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                break;
            // Right
            case 2:
                position = new Vector3(spawnPosX, 0, Random.Range(spawnMinZ, spawnMaxZ));
                rotation = new Vector3(0, -90, 0);
                break;
            default:
                position = new Vector3(0, 0, 0);
                break;
        }

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], position,
            Quaternion.Euler(rotation));
    }
}
