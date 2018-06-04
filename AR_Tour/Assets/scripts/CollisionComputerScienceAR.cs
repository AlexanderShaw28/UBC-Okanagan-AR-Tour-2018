using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionComputerScienceAR : MonoBehaviour {

    public GameObject robot;
    Text count;
    public GameObject Score;
    int rotations = 0;
    public GameObject FinishLine;
    public GameObject Box;
    public GameObject EasterEgg;

    private void Start()
    {
        count = Score.GetComponent<Text>();
    }

    private void Update()
    {
        count.text = "Count:" + rotations;

        if (rotations >= 1  && Box.GetComponent<compSciRotateBox>().enabled == false)
        {
            EasterEgg.SetActive(true);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == robot)
        {
            // detection works just need to change reaction 
            Destroy(collision.gameObject);
            Box.GetComponent<compSciRotateBox>().enabled = false; 
            Debug.Log("hit the robot"); 
        }

        if (collision.gameObject == FinishLine)
        {
            rotations++;
            Debug.Log("Hit FINISH LINE");
        }
    }


}
