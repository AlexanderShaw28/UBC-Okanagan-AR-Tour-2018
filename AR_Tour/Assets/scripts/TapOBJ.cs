using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOBJ : MonoBehaviour
{

    public GameObject uno;
    public GameObject dos;
    public GameObject tres;


    public void OnMouseDown()
    {
        uno.SetActive(true);
        dos.SetActive(false);
        tres.SetActive(false);
    }




}