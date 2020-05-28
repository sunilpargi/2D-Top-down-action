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


    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }

  
}
