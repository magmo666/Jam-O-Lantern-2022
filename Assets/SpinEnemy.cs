using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinEnemy : MonoBehaviour
{

    [SerializeField] private GameObject container;

    [SerializeField] private SpriteRenderer enemySprite;

    private float direction = 1f;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.value > 0.5f)
        {
            direction = 1f;

            enemySprite.flipX = false;
        }
        else
        {
            direction = -1f;
            enemySprite.flipX = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        container.transform.Rotate(0, 0, 100 * direction * Time.deltaTime);
    }
}
