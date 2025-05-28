using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    [SerializeField] private BossSpawner spawner;
    [SerializeField] private GameObject pointer;

    private void Awake()
    {
        spawner = FindAnyObjectByType<BossSpawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spawner.curantArtifacts += 1;
            Destroy(gameObject);
            Destroy(pointer);
        }
        
    }
}
