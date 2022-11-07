using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour
{

    [SerializeField] private GameObject player;

    private Vector2 originalPlayerPos;

    private void Start()
    {
        originalPlayerPos = player.transform.position;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {

            player.transform.position = originalPlayerPos;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            player.transform.position = originalPlayerPos;
        }
    }
}
