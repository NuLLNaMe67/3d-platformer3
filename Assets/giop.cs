using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giop : MonoBehaviour
{
    
    private int health = 10;

    public void TakeDanage(int damage)
    {

        health -= damage;
        print("здоровье;" + health);


    }

}
