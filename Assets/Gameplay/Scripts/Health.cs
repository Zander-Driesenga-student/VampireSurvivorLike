using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth = 10;
    public EXPSystem exp;

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        /*UIValues.OnValueChange.Invoke(gameObject.name + "Health", currentHealth);*/
        /*if (currentHealth <= 0 && gameObject.CompareTag("Enemy"))
        {
            
            Destroy(gameObject);
        }*/
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

        if (targetHealth)
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
}
