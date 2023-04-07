using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   

    // Start is called before the first frame update
    
    [SerializeField] float VitesseMove = 0;
    [SerializeField] float VitesseRotate = 0;

    [SerializeField] float BaseSpeed = 0;
    [SerializeField] float SpeedBoost = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,Input.GetAxis("Horizontal")*(-VitesseRotate)*Time.deltaTime);
        transform.Translate(0,Input.GetAxis("Vertical")*VitesseMove*Time.deltaTime,0);

    }

    public float GetBaseSpeed()
    {
        return BaseSpeed;
    }

    public float GetBoost()
    {
        return SpeedBoost;
    }
    
    public void SetSpeed(float speed)
    {
        VitesseMove = speed;
    }




}
