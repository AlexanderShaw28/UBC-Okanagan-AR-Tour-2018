using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POIColorChange : MonoBehaviour
{

    public Material[] materials;//Allows input of material colors in a set size of array;
    public Renderer Rend; //What are we rendering? Input object(Sphere,Cylinder,...) to render.

    private int index = 0;

    // Use this for initialization
    void Start()
    {
        Rend = GetComponent<Renderer>();//Gives functionality for the renderer
        Rend.enabled = true;//Makes the rendered 3d object visable if enabled;
    }

    void OnMouseDown()
    {

        if (materials.Length == 0)//If there are no materials nothing happens.
            return;

        if (Input.GetMouseButtonDown(0))
        {
            index ++;//When mouse is pressed down we increment up to the next index location
            if(index > 1) { index = 1; }

            print(index);//used for debugging

            Rend.sharedMaterial = materials[index]; //This sets the material color values inside the index
        }
    }
}

//Code source: https://zakalberda.com/2017/03/03/change-color-of-a-game-object-when-clicking-on-it-source-code/