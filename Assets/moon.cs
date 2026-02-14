using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {


        transform.position +=
            transform.forward *
            speed * Time.deltaTime;


        
    }

       void OnTriggerEnter(Collider other) {

        Destroy(gameObject);
        dd enemy = other.GetComponent<dd>();
        Destroy(enemy.gameObject);
       


    }
}
