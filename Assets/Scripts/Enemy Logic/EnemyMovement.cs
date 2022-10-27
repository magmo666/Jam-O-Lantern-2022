using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform enemyContainerTransform;

    [SerializeField] private float speed = -10f;
    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Debug.Log("No player has been detected.");
            return;
        }
        float step = speed * Time.deltaTime;
        enemyContainerTransform.position = Vector2.MoveTowards(enemyContainerTransform.position, player.transform.position, step);
    }
}
