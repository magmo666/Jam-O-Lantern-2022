using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAoE : MonoBehaviour
{
    IEnumerator coroutine;
    public int decreaseHealth = 1;
    public float damageInterval = 0.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has collided with enemy collider.");
            if (coroutine != null) return; 
            coroutine = DamageOverTime(collision.gameObject.GetComponent<PlayerHealth>());
            StartCoroutine(coroutine);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player has left collider.");
        if (coroutine == null) return;
        StopCoroutine(coroutine);  
    }

    IEnumerator DamageOverTime(PlayerHealth health)
    {
        while (true)
        {
            Debug.Log("Player has taken damage.");
            health.TakeDamage(decreaseHealth);
            yield return new WaitForSeconds(damageInterval);
        }
    }
}

