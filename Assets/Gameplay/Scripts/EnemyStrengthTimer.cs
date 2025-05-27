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
    void Start()
    {
        enemySpawner = FindAnyObjectByType<EnemySpawner>();
    }

    
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= nextBoost) 
        {
            enemySpawner.maxEnemies += 10;
            enemySpawner.enemiesToSpawn += 5;
            Health.TryHeal(enemy, 10);
            if (damageBoost == boostsToDamageBoost)
            {
                Enemy.damage2 += 1;
                damageBoost = 0;
            }
            nextBoost += timeIncrease;
        }
    }
}
