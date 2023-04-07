using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{   
    // Start is called before the first frame update
    Driver car;
    void Start()
    {
       car = GetComponent<Driver>(); 
       Debug.Log("car : " + car.GetBaseSpeed()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Boost")
        {   
            Debug.Log("Boost");
            car.SetSpeed(car.GetBoost());
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Aie");
            car.SetSpeed(car.GetBaseSpeed());
        }
        
    }
}
