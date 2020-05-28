using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject fireBall;
    public Transform shotPoint;
    public float timeBetweenShots;

    private float shotTime;

    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.rotation = rotation;
        print("ROtate");

        if (Input.GetMouseButton(0))
        {
            if(Time.time > shotTime)
            {
                Instantiate(fireBall, shotPoint.position, Quaternion.identity);

                shotTime = Time.time + timeBetweenShots;
            }
        }
    }

}
