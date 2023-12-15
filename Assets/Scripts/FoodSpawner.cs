using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject[] foods; // Array of game objects to spawn
    public float spawnInterval = 3f; // Time between spawns
    public float spawnOffset = 1f; // Offset value for spawning higher
    public float farEdgeSpawnChance = 0.1f; // Chance to spawn at far left or far right
    private float cameraTop; // Top of the camera's view in world coordinates
    private float cameraRightEdge; // Right edge of the camera's view in world coordinates
    private float cameraLeftEdge; // Left edge of the camera's view in world coordinates

    void Start()
    {
        // Check if the objectsToSpawn array is empty
        if (foods.Length == 0)
        {
            Debug.LogError("No objects assigned to spawn!");
            return;
        }

        // Calculate the camera's view edges in world coordinates
        float cameraHeight = Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;
        cameraTop = Camera.main.transform.position.y + cameraHeight + spawnOffset;
        cameraRightEdge = Camera.main.transform.position.x + cameraWidth;
        cameraLeftEdge = Camera.main.transform.position.x - cameraWidth;

        // Start spawning objects
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void SpawnObject()
    {
        // Check if the objectsToSpawn array is empty or null
        if (foods == null || foods.Length == 0)
        {
            Debug.LogError("No objects assigned to spawn!");
            return;
        }

        float randomX;

        // Randomly decide whether to spawn at the far left/right or within the camera's view
        bool spawnAtEdge = Random.value < farEdgeSpawnChance;

        if (spawnAtEdge)
        {
            // Spawn at far left or far right
            bool spawnAtLeft = Random.value < 0.5f;
            randomX = spawnAtLeft ? cameraLeftEdge : cameraRightEdge;
        }
        else
        {
            // Spawn randomly within the camera's view
            randomX = Random.Range(cameraLeftEdge, cameraRightEdge);
        }

        // Calculate the spawn position slightly above the top of the camera's view
        Vector3 spawnPosition = new Vector3(randomX, cameraTop, 0f);

        Debug.Log("Spawn position: " + spawnPosition); // Log spawn position

        // Randomly select an object from the array
        GameObject objectToSpawn = foods[Random.Range(0, foods.Length)];

        // Instantiate the selected object at the calculated position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

}
