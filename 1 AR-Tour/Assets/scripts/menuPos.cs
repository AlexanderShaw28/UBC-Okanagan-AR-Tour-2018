using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuPos : MonoBehaviour {

    // Player
    public GameObject player;

    // Static Poi's
    public GameObject ecolPoi;
    public GameObject uncPoi;
    public GameObject histPoi;
    public GameObject eescPoi;
    public GameObject philPoi;
    public GameObject econPoi;

    // AR Poi's
    public GameObject compPoi;
    public GameObject bioPoi;
    public GameObject psychPoi;
    public GameObject barkPoi;

    // Static Menu's
    public GameObject ecolMenu;
    public GameObject uncMenu;
    public GameObject histMenu;
    public GameObject eescMenu;
    public GameObject philMenu;
    public GameObject econMenu;

    // Player Position
    Vector3 position;

    // Static Poi Positions
    Vector3 ecolPos;
    Vector3 econPos;
    Vector3 histPos;
    Vector3 uncPos;
    Vector3 philPos;
    Vector3 eescPos;

    // AR Poi Positions
    Vector3 compSciPos;
    Vector3 barkPos;
    Vector3 psychPos;
    Vector3 microBioPos;

    // Static Poi Booleans
    // Set False if not close to Poi
    bool ecolOpen = false;
    bool econOpen = false;
    bool histOpen = false;
    bool uncOpen = false;
    bool philOpen = false;
    bool eescOpen = false;

    // AR Poi Booleans
    // Set False if not at Scene
    bool compSciOpen = false;
    bool barkOpen = false;
    bool psychOpen = false;
    bool microBioOpen = false;

    // AR Scene Numbers
    public int compsci;
    public int simpleAr;
    public int psychAr;
    public int microBioAr;


    void Update () {

        // Find player Position
        position = player.transform.position;

        // Find Static Poi Position
        ecolPos = ecolPoi.transform.position;
        econPos = econPoi.transform.position;
        histPos = histPoi.transform.position;
        uncPos = uncPoi.transform.position;
        philPos = philPoi.transform.position;
        eescPos = eescPoi.transform.position;

        // Find AR Poi Position
        compSciPos = compPoi.transform.position;
        psychPos = psychPoi.transform.position;
        microBioPos = bioPoi.transform.position;
        barkPos = barkPoi.transform.position;


        // Check Distance Between Positiions
        // Open Menu if less than 4 units away

        // STATIC POI's
        // ECOLOGY
        if (Vector3.Distance(position, ecolPos) < 4 && ecolOpen == false )
        {
            ecolMenu.SetActive(true);
            ecolOpen = true;
        }

        if (Vector3.Distance(position, ecolPos) > 6 && ecolOpen == true)
        {
            ecolOpen = false;
        }

        // HISTORY
        if (Vector3.Distance(position, histPos) < 4 && histOpen == false)
        {
            histMenu.SetActive(true);
            histOpen = true;
        }

        if (Vector3.Distance(position, histPos) > 6 && histOpen == true)
        {
            histOpen = false;
        }

        // UNC
        if (Vector3.Distance(position, uncPos) < 4 && uncOpen == false)
        {
            uncMenu.SetActive(true);
            uncOpen = true;

        }

        if (Vector3.Distance(position, uncPos) > 6 && uncOpen == true)
        {
            uncOpen = false;
        }

        // PHIL
        if (Vector3.Distance(position, philPos) < 4 && philOpen == false)
        {
            philMenu.SetActive(true);
            philOpen = true;
        }

        if (Vector3.Distance(position, ecolPos) > 6 && philOpen == true)
        {
            philOpen = false;
        }

        // ECON
        if (Vector3.Distance(position, econPos) < 4 && econOpen == false)
        {
            econMenu.SetActive(true);
            econOpen = true;
        }


        if (Vector3.Distance(position, econPos) > 6 && econOpen == true)
        {
            econOpen = false;
        }

        // EESC
        if (Vector3.Distance(position, eescPos) < 4 && eescOpen == false)
        {
            eescMenu.SetActive(true);
            eescOpen = true;
        }

        if (Vector3.Distance(position, eescPos) > 6 && eescOpen == true)
        {
            eescOpen = false;
        }

        // AR SCENES

        // CompSci
        if (Vector3.Distance(position, compSciPos) < 4 && compSciOpen == false)
        {
           SceneManager.LoadScene(compsci);
           compSciOpen = true;
        }

        if (Vector3.Distance(position, compSciPos) > 6 && compSciOpen == true)
        {
            compSciOpen = false;
        }

        // Psych
        if (Vector3.Distance(position, psychPos) < 4 && psychOpen == false)
        {
            SceneManager.LoadScene(psychAr);
            psychOpen = true;
        }

        if (Vector3.Distance(position, psychPos) > 6 && psychOpen == true)
        {
            psychOpen = false;
        }

        // Bio
        if (Vector3.Distance(position, microBioPos) < 4 && microBioOpen == false)
        {
            SceneManager.LoadScene(microBioAr);
            microBioOpen = true;
        }

        if (Vector3.Distance(position, microBioPos) > 6 && microBioOpen == true)
        {
            microBioOpen = false;
        }

        // Bark
        if (Vector3.Distance(position, barkPos) < 4 && barkOpen == false)
        {
            SceneManager.LoadScene(compsci);
            barkOpen = true;
        }

        if (Vector3.Distance(position, barkPos) > 6 && barkOpen == true)
        {
            barkOpen = false;
        }
    }
}
