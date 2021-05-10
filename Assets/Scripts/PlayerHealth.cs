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

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            StartCoroutine(Die());
        }
        else
            healthManager.SetHealth(currentHealth);

    }

    public void Heal(int heal)
    {
        currentHealth += heal;
        if (currentHealth>= maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthManager.SetHealth(currentHealth);
    }

    public IEnumerator Die()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Menu");
    }

}
