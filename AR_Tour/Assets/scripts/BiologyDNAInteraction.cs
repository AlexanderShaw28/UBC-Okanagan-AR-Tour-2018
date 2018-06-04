using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiologyDNAInteraction : MonoBehaviour {

    public GameObject anti;
    public GameObject sense;
    int EO = 0; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit(); 

        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "DNA"  &&  sense.activeSelf == false && anti.activeSelf == false)
                {
                    anti.SetActive(true);
                    sense.SetActive(false);
                    EO++;
                    Debug.Log("anti Active");
                }

                if (hit.collider.name == "DNA" && anti.activeSelf == true)
                {
                    anti.SetActive(false);
                    sense.SetActive(true);
                    EO++;
                    Debug.Log("sense Active"); 
                }

                else
                {
                    anti.SetActive(false);
                    sense.SetActive(false);
                    Debug.Log("NOTHING ACTIVE"); 
                }
            }
        }
	}
}
