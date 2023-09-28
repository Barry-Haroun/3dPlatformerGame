using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    [SerializeField] private float currentHealth;

    //[SerializeField] private float attack;

    public HealthBar healthBar;
    public GameManager gamManager;
    private bool isDead;
    //private bool hasCollideWithWinCondition = false;
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


    //private void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.CompareTag("MagicDoor")) 
        //{
            //hasCollideWithWinCondition = true;
            //SceneManager.LoadScene("GameController");
            //gameObject.SetActive(false);
        //}
    //}



    private void Update()
    {
        if (currentHealth > maxHealth) 
        {
            currentHealth = maxHealth;
        }
        
        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gamManager.gameOver();
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("You died");
    }

}
