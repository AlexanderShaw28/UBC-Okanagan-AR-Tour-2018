using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotJump : MonoBehaviour
{


    float force = 50;
    float forceDwn = -50; 
    public Rigidbody rb;
    float pose;
    float upPosition;
    public GameObject tapPrompt;
    public GameObject Box; 
 


    void Start()
    {
        pose = rb.position.y;
        pose = Mathf.Round(pose);
       
    }

    private void Update()
    {
        upPosition = Mathf.Round(rb.position.y);
        if (upPosition >= 70)
        {
            Debug.Log("upPosition");
            rb.AddForce(rb.transform.up * forceDwn, ForceMode.VelocityChange);
        }
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        Box.GetComponent<compSciRotateBox>().enabled = true; 

        float currentPose = Mathf.Round(rb.position.y);

        Debug.Log("start position: "+ currentPose);
        Debug.Log("current position: " + pose); 
       
       if (currentPose== (pose))
        {

            rb.AddForce(rb.transform.up * force, ForceMode.VelocityChange);
            tapPrompt.SetActive(false); 
          
        }
    }
}