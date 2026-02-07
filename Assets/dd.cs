using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dd : MonoBehaviour
{

    public float speed;
    public Transform target;
    public int playerDamage = 2;

         
    void Update()
    {
        //rflhgvtyqcz
        transform.position =
            Vector3.MoveTowards(transform.position,
            target.position, speed * Time.deltaTime);

        //  rthyj
        transform.LookAt(target.position);
    }

}
