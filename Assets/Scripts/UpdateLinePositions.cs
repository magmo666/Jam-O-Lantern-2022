using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLinePositions : MonoBehaviour
{

    [SerializeField] private LineRenderer EnemyLineRenderer;

    private Transform[] points;





    public void SetUpLine(Transform[] points)
    {
        EnemyLineRenderer.positionCount = points.Length;
        this.points = points;
    }



    private void Update()
    {
        for(int i = 0; i < points.Length; i++)
        {
            EnemyLineRenderer.SetPosition(i, points[i].position);
        }
    }
}
