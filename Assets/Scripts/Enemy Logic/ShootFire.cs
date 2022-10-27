using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour
{
    [SerializeField] private GameObject fire;
    public float fireRate = 2;
    public float nextFire;
    [SerializeField] private GameObject shootingPoint; //point at which it shoots from
    [SerializeField] private GameObject player;

    void FixedUpdate()
    {
        CheckIfTimeToFire();
    }

    //creates and shoots a fireball
    void CheckIfTimeToFire()
    {
        //checks if its time to shoot a new fireball
        if (Time.fixedDeltaTime > nextFire)
        {
            //shoots in direction of player
            Vector2 direction = player.transform.position;
            GameObject clone = Instantiate(fire, shootingPoint.transform.position, transform.rotation);
            clone.GetComponent<Rigidbody2D>().velocity = direction;
            nextFire = Time.fixedDeltaTime + fireRate;
        }
    }
}
