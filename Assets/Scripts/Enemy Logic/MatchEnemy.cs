using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchEnemy : EnemyMovement
{
    [SerializeField] private float decrease = 0.01f;
    [SerializeField] private Vector3 scale;
    private void Start()
    {
        scale = new Vector3(decrease, decrease, decrease);
        StartCoroutine(Extinguish());
    }
    IEnumerator Extinguish()
    {
        while (enemy.transform.localScale.y > 0.1f)
        {
            enemy.transform.localScale -= scale;
            yield return new WaitForSeconds(Time.fixedDeltaTime);
        }
        Destroy(enemy);
    }
}
