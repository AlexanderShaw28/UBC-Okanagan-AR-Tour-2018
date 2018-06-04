using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickPoi : MonoBehaviour
{

    public float force = 5;

    public GameObject uncMenu;
    public GameObject historyMenu;
    public GameObject eescMenu;
    public GameObject ecologyMenu;
    public GameObject econMenu;
    public GameObject philMenu;


    // Dictionary<string, GameObject> PoiDict = new Dictionary<string, GameObject>();


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {

                    Rigidbody rb;


                    if (rb = hit.transform.GetComponent<Rigidbody>())

                    {
                        string name = hit.transform.gameObject.name;
                        //PrintName(hit.transform.gameObject);
                        LaunchIntoAir(rb);
                        print(name);


                        //  AR POIs
                        /* 
                        
                        try
                        {
                            
                            SceneManager.LoadScene(name, LoadSceneMode.Single);
                        }catch(System.Exception )
                        {
                        }
                        */

                        //Non AR POIs
                        //add all points to a dictionary for accessing
                        /*
                        PoiDict.Add("UNC", uncMenu);
                        PoiDict.Add("History", historyMenu);
                        PoiDict.Add("EESC", eescMenu);
                        PoiDict.Add("Ecology", ecologyMenu);
                        PoiDict.Add("Econ", econMenu);
                        PoiDict.Add("Phil", philMenu);
                        //set clicked menu active
                        PoiDict[name].SetActive(true);
                        */


                        // Static Scences
                        if (name == "unc")
                        {
                            uncMenu.SetActive(true);

                            historyMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);
                        }

                        if (name == "history")
                        {
                            historyMenu.SetActive(true);

                            uncMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "eesc")
                        {
                            eescMenu.SetActive(true);

                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "ecology")
                        {
                            ecologyMenu.SetActive(true);

                            eescMenu.SetActive(false);
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);
                            philMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "phil")
                        {
                            philMenu.SetActive(true);

                            ecologyMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);
                            econMenu.SetActive(false);

                        }
                        if (name == "econ")
                        {
                            econMenu.SetActive(true);

                            philMenu.SetActive(false);
                            ecologyMenu.SetActive(false);
                            eescMenu.SetActive(false);
                            historyMenu.SetActive(false);
                            uncMenu.SetActive(false);

                        }
                        // Ar Scenes
                        if (name == "simpleAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "ChemAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "PsychAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "MicroBioAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }
                        if (name == "ComputerScienceAr")
                        {
                            try
                            {
                                SceneManager.LoadScene(name, LoadSceneMode.Single);
                            }
                            catch (System.Exception)
                            {

                            }
                        }

                    }
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void LaunchIntoAir(Rigidbody rig)
    {

        rig.AddForce(rig.transform.up * force, ForceMode.Impulse);


    }

}