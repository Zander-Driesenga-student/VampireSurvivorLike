using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemiesInRange = new List<GameObject>();
    public GameObject EnemyPrefab;
    public float distance = 20.0f;
    private float spawnRate = 5.0f;
    public float startSpawnRate = 5.0f;
    public int maxEnemies = 10;
    public int enemiesToSpawn = 5;
    public int curentEnemies;

    private void Start()
    {
        spawnRate = startSpawnRate;
    }

    void Update()
    {
        curentEnemies = enemiesInRange.Count;
        spawnRate -= Time.deltaTime;
        if (spawnRate <= 0 && curentEnemies < maxEnemies)
        {
            for (int i = 0; i < enemiesToSpawn && i < maxEnemies; i++)
            {
                SpawnEnemy();
                spawnRate = startSpawnRate;
            }

        }
    }
    void SpawnEnemy()
    {
        Vector2 spawnPos = transform.position;

        float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
        Vector2 delta = new Vector2(Mathf.Cos(angle) * distance, Mathf.Sin(angle) * distance);
        Vector2 enemySpawn = spawnPos + delta;
        Instantiate(EnemyPrefab, enemySpawn, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemiesInRange.Add(other.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemiesInRange.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
