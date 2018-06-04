using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SwitchPanel : MonoBehaviour
{

    public GameObject infoPanel;
    public GameObject picPanel;
    public GameObject vidPanel;
    int info = 1; int pic = 1; int vid = 1;

    public void openInfo()
    {
        if (info % 2 == 1)
        {
            infoPanel.SetActive(true);
            picPanel.SetActive(false);
            vidPanel.SetActive(false);
            Debug.Log("Info Opened");
            info++;
        }
        else
        {
            infoPanel.SetActive(false);
            Debug.Log("Info Closed");
            info++;
        }
    }

    public void openPic()
    {
        if (pic % 2 == 1)
        {
            infoPanel.SetActive(false);
            picPanel.SetActive(true);
            vidPanel.SetActive(false);
            Debug.Log("Pictures Opened");
            pic++;
        }
        else
        {
            picPanel.SetActive(false);
            Debug.Log("Pictures Closed");
            pic++;
        }
    }

    public void openVid()
    {
        if (vid % 2 == 1)
        {
            infoPanel.SetActive(false);
            picPanel.SetActive(false);
            vidPanel.SetActive(true);
            Debug.Log("Video Opened");
            vid++;
        }
        else
        {
            vidPanel.SetActive(false);
            Debug.Log("Video Closed");
            vid++;
        }
    }
}