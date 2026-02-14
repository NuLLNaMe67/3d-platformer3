using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giop : MonoBehaviour
{
    
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;


    public void TakeDanage(int damage)
    {

        health -= damage;
        print("здоровье;" + health);


    }

    void Udpate() {


        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(fireballPrefab,
            attackPoint.
                position, attackPoint.rotation);
        }
    }

    }
