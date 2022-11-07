using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{

    [SerializeField] private GameObject player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (player.transform.position.x < transform.position.x)
        {
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }
        else
        {
            transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
        }




    }
}