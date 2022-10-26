using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 10f;
    public float currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageDealt) 
    {
        Debug.Log("Player health is now " + currentHealth + ".");
        currentHealth -= damageDealt;

        //healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Player died.");
            Destroy(gameObject);
            //SceneManager.LoadScene("MainMenuScene"); //temporary
        }
    }
}
