using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStrengthTimer : MonoBehaviour
{
    public float Timer;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject enemyBoss;
    public float timeIncrease;
    private float nextBoost;
    public EnemySpawner enemySpawner;
    public int damageBoost = 0;
    public int boostsToDamageBoost = 3;
    public Text time;
    public int maxEnemyIncrease;
    public int enemyToSpawnIncrease;
    public int healthBoost;
    public int damageBoostincrease;
    void Start()
    {
        enemySpawner = FindAnyObjectByType<EnemySpawner>();
    }

    
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= nextBoost) 
        {
            enemySpawner.maxEnemies += maxEnemyIncrease;
            enemySpawner.enemiesToSpawn += enemyToSpawnIncrease;
            Health.TryHeal(enemy, healthBoost);
            if (damageBoost == boostsToDamageBoost)
            {
                Enemy.damage2 += damageBoostincrease;
                damageBoost = 0;
            }
            nextBoost += timeIncrease;
        }
    }
}
