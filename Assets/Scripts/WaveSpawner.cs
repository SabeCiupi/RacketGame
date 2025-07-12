using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[System.Serializable]

public class Wave
{
    public string name;
    public int nrOfEnemies;
    public GameObject[] typeOfEnemies; // - future feature
    public float spawnInterval;
}

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    public WaveUIManager uiManager;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    public bool canSpawn = true;
    private bool isWaveStarting = false;

    void Start()
    {
        currentWave = waves[currentWaveNumber];
        StartCoroutine(StartWaveSequence());
    }

    private void Update()
    {
        if (!isWaveStarting && currentWaveNumber < waves.Length)
        {
            StartCoroutine(StartWaveSequence());
        }
    }

    private IEnumerator StartWaveSequence()
    {
        isWaveStarting = true;
        currentWave = waves[currentWaveNumber];

        yield return StartCoroutine(uiManager.ShowWaveStart(currentWave.name));

        canSpawn = true;

        while (GameObject.FindGameObjectsWithTag("Enemy").Length > 0 || currentWave.nrOfEnemies > 0)
        {
            SpawnWave();
            yield return null;
        }

        yield return StartCoroutine(uiManager.ShowWaveComplete());

        currentWaveNumber++;
        isWaveStarting = false;
    }

    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.nrOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
            if (currentWave.nrOfEnemies == 0)
            {
                canSpawn = false;
            }
        }

    }
    
}
