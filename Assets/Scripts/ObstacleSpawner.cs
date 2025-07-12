using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles; // prefabs with planets
    public float spawnRate = 2f; // time between spawns
    public float yRange = 16f; // how high/low to spawn
    public float xSpawn = 20f; //spawn to the right of the screen
    public float moveSpeed = 2f; // speed
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnRate);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(xSpawn, Random.Range(-yRange, yRange), 0);
        GameObject planet = Instantiate(obstacles[Random.Range(0, obstacles.Length)], spawnPos, Quaternion.identity);
        planet.AddComponent<MovingObstacle>().speed = moveSpeed;
    }
}
