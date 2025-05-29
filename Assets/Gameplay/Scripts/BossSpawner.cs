using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public int artifactsToBoss = 4;
    public int curantArtifacts = 0;
    public float distance = 10.0f;
    public bool bossActive = false;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (curantArtifacts == artifactsToBoss && bossActive == false)
        {
            bossActive = true;
            SpawnBoss();
        }
    }
    void SpawnBoss()
    {
        Vector2 spawnPos = transform.position;

        float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
        Vector2 delta = new Vector2(Mathf.Cos(angle) * distance, Mathf.Sin(angle) * distance);
        Vector2 enemySpawn = spawnPos + delta;
        bossPrefab.SetActive(true);
        bossPrefab.transform.position = enemySpawn;
    }
}
