    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimations : MonoBehaviour
{

    public GameObject dog;
    int girlC = 0;
    int dogC = 0;
    public Animator charAnim;
    Animator dogAnim;
 
    

    // Use this for initialization
    void Start()
    {

        dogAnim = dog.GetComponent<Animator>(); 

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.name == "SportyGirl")
                {
                    Debug.Log("NAME: " + hit.collider.name);
                    Debug.Log("GIRL COUNT:" + girlC);
                    
                    if (girlC % 3 == 0)
                    {
                        charAnim.Play("sneak");
                        girlC++;
                    }
                    else if (girlC % 3 == 1)
                    {
                        charAnim.Play("Jump");
                        girlC++;
                    }
                    else if (girlC % 3 == 2)
                    {
                        charAnim.Play("walk");
                        
                    }
                }
                if (hit.collider.name == "Beagle")
                {
                    Debug.Log("DOG COUNT: " + dogC); 
                   
                    if (dogC % 3 == 0)
                    {
                        dogAnim.Play("BeagleIdleSniff");
                        dogC++;
                    }
                    else if (dogC % 3 == 1)
                    {
                        dogAnim.Play("BeagleRun");
                        dogC++;
                    }
                    else if (dogC % 3 == 2)
                    {
                        dogAnim.Play("BeagleIdleDig");
                        dogC++;
                    }
                }
                
            }
        }
    }
}

