using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 20;
    public float speed;

    [HideInInspector]
    public Transform player;

    public float timeBetweenAttack;
    public int damage = 10;

    public int pickUpChance;
    public GameObject[] pickUps;


    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health < 0)
        {
            int randomNumer = Random.Range(0, 101);
            if(randomNumer < pickUpChance)
            {
                GameObject randomPickUp = pickUps[Random.Range(0, pickUps.Length)];
                Instantiate(randomPickUp, transform.position, transform.rotation);
            }

            Destroy(gameObject);
        }
    }

  
}
