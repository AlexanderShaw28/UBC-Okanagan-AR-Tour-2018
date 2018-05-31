using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switchBarkImage : MonoBehaviour {

    public Sprite doggo1;
    public Sprite doggo2;
    public Sprite doggo3;
    public Sprite doggo4;
    public Sprite doggo5;
    public Sprite doggo6;
    public Sprite doggo7;
    public Sprite doggo8;
    public Sprite doggo9;
    public GameObject Main;
    string scene = "Information"; 
    

 
    public void SwitchImage(string image)
    {

        if (image == "A") {
          
        Main.GetComponent<Image> ().sprite = doggo1;
        }     

        if (image == "B") {
        Main.GetComponent<Image> ().sprite = doggo2;
        }                       
        if (image == "C")
        {
            Main.GetComponent<Image>().sprite = doggo3;
        }
        if (image == "D")
        {
            Main.GetComponent<Image>().sprite = doggo4; 
        }
        if (image == "E")
        {
            Main.GetComponent<Image>().sprite = doggo5;
        }
        if (image == "F")
        {
            Main.GetComponent<Image>().sprite = doggo6; 
        }
        if (image == "G")
        {
            Main.GetComponent<Image>().sprite = doggo7;
        }
        if (image == "H")
        {
            Main.GetComponent<Image>().sprite = doggo8;
        }
        if (image == "I")
        {
            Main.GetComponent<Image>().sprite = doggo9;
        }
     }	

}
