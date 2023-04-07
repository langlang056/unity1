using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // Start is called before the first frame update
    int nbPackage = 0;
    void Start()
    {
        
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package") {
            Debug.Log("You have taken the package");
            nbPackage++;
            Destroy(other.gameObject);
        }

        if (other.tag == "Client" && nbPackage >= 1) {
            Debug.Log("You have delivered " + nbPackage + " package(s)");
            nbPackage = 0;
        } 
        else if (other.tag == "Client" && nbPackage == 0) 
        {
            Debug.Log("You have not delivered the package");
        }

        
    }


        


        
    
}
