using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10.0f;
    public float targetTime = 10.0f;
    public int damage = 1;
    public bool isPiercing = false;
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("Boss"))
        {
            Health.TryDamage(collision.gameObject, damage);
            if (isPiercing == false)
            {
                Destroy(gameObject);
            }
            
        }
    }
}
