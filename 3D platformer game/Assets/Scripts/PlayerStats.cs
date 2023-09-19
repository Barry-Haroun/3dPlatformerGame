using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    [SerializeField] private float currentHealth;

    // [SerializeField] private float attack;

    public HealthBar healthBar;
    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
        Debug.LogError(amount);
    }

    public void Heal(float amount) 
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth);
        Debug.LogError(currentHealth);

       // currentHealth += amount;
      //  if (currentHealth > maxHealth) currentHealth = maxHealth;

    }






    private void Update()
    {
        if (currentHealth > maxHealth) 
        {
            currentHealth = maxHealth;
        }
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("You died");
    }

}
