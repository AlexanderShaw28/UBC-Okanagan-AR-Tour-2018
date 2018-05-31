using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationServices : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        // Turn on location services, if avialable
        // accuracy set to 5m, every 0.5m
        Input.location.Start(5,0.5f);
        
        /*
        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            print("Timed out");
            yield break;
        }
        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            print("Unable to determine device location");
            yield break;
        }
        */
    }
	
	// Update is called once per frame
	private void Update () {
        UpdateLocation();
    }

    private void UpdateLocation()
    {
        // Do nothing if location services are not available
        if (Input.location.isEnabledByUser)
        {
            float lat = Input.location.lastData.latitude;
            float lon = Input.location.lastData.longitude;

            Text locationText = GameObject.Find("locationButton").GetComponentInChildren<Text>();

            locationText.text = "Depart lat: " + lat + " lon: " + lon + "accuracy:" + Input.location.lastData.horizontalAccuracy;
        }
    }
}
