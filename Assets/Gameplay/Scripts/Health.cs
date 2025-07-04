using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public bool canDie = true;
    public HealthBar healthBar;
    public UnityEvent onZeroHealth = new UnityEvent();

    public void Start()
    {
        healthBar = FindAnyObjectByType<HealthBar>();
        if (gameObject.CompareTag("Player"))
        {
            healthBar.SetMaxHealth(currentHealth);
        }

    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (gameObject.CompareTag("Player"))
        {
            healthBar.SetHealth(currentHealth);
        }
        if (currentHealth <= 0 && canDie == true)
        {
            OnZeroHealth();
        }
    }
    public static void TryDamage(GameObject target, int damageAmount)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth)
        {
            targetHealth.TakeDamage(damageAmount);
        }
    }
    public static void TryHeal(GameObject target, int HealAmount)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth && target.CompareTag("Enemy"))
        {
            targetHealth.AddHealth(HealAmount);
        }
        else if (targetHealth && target.CompareTag("Player"))
        {
            targetHealth.AddHealth(HealAmount);
        }
    }
    /*public static void TryIncreaseHealth(GameObject target, int HealAmount)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth)
        {
            targetHealth.AddHealth(HealAmount);
        }
    }*/
    public void AddHealth(int health)
    {
        currentHealth += health;
    }
    public void AddPlayerHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }
    public static void TryStartHealth(GameObject target, int HealAmount)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth)
        {
            targetHealth.StartHealth(HealAmount);
        }
    }
    public void StartHealth(int health)
    {
        currentHealth = health;
    }
    public void OnZeroHealth()
    {
        onZeroHealth.Invoke();
    }

}
