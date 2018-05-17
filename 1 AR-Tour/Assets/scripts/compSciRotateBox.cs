using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class compSciRotateBox : MonoBehaviour
{

    float timeCounter = 1;
    float speed, radius; 


    void Start()
    {
        speed = 0.4f ;
        radius = 220;              
        
    }

    void Update()
    {     
        //Debug.Log(cur); 

        timeCounter += Time.deltaTime * speed;
        
        float x = Mathf.Sin(timeCounter) * radius;
        float y = -35;
        float z = Mathf.Cos(timeCounter) * radius;

        transform.position = new Vector3(x, y, z);

        
    }

 


}