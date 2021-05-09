using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthManager healthManager;

    private void Start()
    {
        currentHealth = maxHealth;
        healthManager.SetMaxHealth(maxHealth);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
            healthManager.SetHealth(currentHealth);

    }

    void Heal(int heal)
    {
        currentHealth += heal;
        if (currentHealth>= maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthManager.SetHealth(currentHealth);
    }
}
