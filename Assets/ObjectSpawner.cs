using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Prefab of the object to spawn
    public Transform[] spawnPoints; // Array of spawn points
    public float spawnDelay = 1f; // Delay before spawning objects

    void Start()
    {
        StartCoroutine(SpawnObjectsWithDelay());
    }

    IEnumerator SpawnObjectsWithDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(spawnDelay);

        // Loop through each spawn point
        foreach (Transform spawnPoint in spawnPoints)
        {
            // Instantiate the object at the spawn point's position and rotation
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
