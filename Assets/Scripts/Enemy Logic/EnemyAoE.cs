using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAoE : MonoBehaviour
{

    //[Serialize Field] private GameObject player;
    // Start is called before the first frame update
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
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
            Debug.Log("Player has collided with enemy collider.");

        }
    }
}

