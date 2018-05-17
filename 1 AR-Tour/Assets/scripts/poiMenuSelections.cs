using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class poiMenuSelections : MonoBehaviour {


    public GameObject Menu;
    


    public GameObject imagePanel;
    public GameObject videoPanel;
    public GameObject infoPanel;

    public void openImage()
    {
       imagePanel.SetActive(true);

        videoPanel.SetActive(false);
        infoPanel.SetActive(false);
    }

    public void openVideo()
    {
        videoPanel.SetActive(true);

        imagePanel.SetActive(false);
        infoPanel.SetActive(false);
    }

    public void openInfo()
    {
        infoPanel.SetActive(true);

        imagePanel.SetActive(false);
        videoPanel.SetActive(false);
    }

    public void closeMenu()
    {
        infoPanel.SetActive(false);
        imagePanel.SetActive(false);
        videoPanel.SetActive(false);
        Menu.SetActive(false);
    }

    

    public void external(string link)
    {
        
        Application.OpenURL(link);

    }


}
