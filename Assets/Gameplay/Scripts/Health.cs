using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth = 10;


    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        /*UIValues.OnValueChange.Invoke(gameObject.name + "Health", currentHealth);*/
        if (currentHealth <= 0 && gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
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

}
