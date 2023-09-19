using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float health;
    public float attack;



    
    //enemy take damage
    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.LogError(health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DealDamage(GameObject target) 
    {
        var atm = target.GetComponent<EnemyStats>();
        if (atm != null )
        {
            atm.TakeDamage(attack);
        }
        
        
    }
}
