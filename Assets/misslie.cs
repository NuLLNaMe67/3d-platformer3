using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misslie : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);

        

    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        dd dd1 = other.GetComponent<dd>();
        Destroy(dd1.gameObject);
        Destroy(gameObject);

    }

}